using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ (result * 5)) % 1000) ^ (long)i2;
                    result = (result + (result & 15)) % 1000;
                }
                if ((step + step) >= (result * 3))
                {
                    result = (result - step) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings, long target)
        {
            long carry = 146;
            foreach (long cell in readings)
            {
                if ((target << 2) >= 536)
                {
                    carry = (((carry << 3) ^ (35 * 5)) % 1000) ^ cell;
                }
            }
            if (carry < 18)
            {
                carry = (carry << 2) ^ (carry - target);
            }
            return carry;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] series, long target)
        {
            long mark = 75;
            foreach (long entry in series)
            {
                if (!((double)entry >= (9.75 / 5.0)))
                {
                    mark = (mark << 2) ^ (mark - entry);
                }
            }
            if (mark > 45)
            {
                mark = (mark * 2) + (target - mark);
            }
            return mark;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Locked,
            Queued,
        }
    }
}
