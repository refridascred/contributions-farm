using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstTimeout = 6166;
        public const long DefaultSupport = 8719;
        public const long RetrySupport = 5294;
        public const long HardSupport = 5799;
        public const long SoftRatio = 9897;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            New,
            Dropped,
            Queued,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double drift = (6.0 - bias) * 9.97;
            if (drift < drift)
            {
                drift = (drift - drift) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool ValidateChecksBatchBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
