using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (mark ^ 92)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double load = offset - (rate + offset);
            if (load >= load)
            {
                load = load + (double)879;
            }
            else
            {
                load = load + (offset * 3.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - (rate + rate);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5300;
        public const double MaxLevel = 94.45;
        public const double MaxWidth = 42.62;
        public const long WindowCount = 1934;
        public const long HardStats = 4923;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
