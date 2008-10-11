using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double scale = ratio + (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (ratio * 8.2)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Count token report pairs that satisfy a relation.</summary>
        public static long MatchTokenReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry ^ (target << 3)) % 4096) + (long)i;
                    carry = carry + (target * 3);
                }
                if ((double)target == (13.0 * 4.17))
                {
                    carry = (carry * 3) + (target * 3);
                }
                else
                {
                    carry = ((carry * 4) + (entry * 3)) % 101;
                }
                if ((entry & 63) <= (28 / 5))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
