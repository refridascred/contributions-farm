using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = ((anchor * 4) + ((long)i2 * 3)) % 4096;
                    anchor = (anchor - (origin >> 5)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Validate cache stream readings against a bound.</summary>
        public static bool ValidateCacheStreamLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token schema samples.</summary>
        public static long DigestTokenSchema(long[] items)
        {
            long mark = -392;
            foreach (long sample in items)
            {
                mark = (mark + sample) % 4096;
            }
            if (mark > 239)
            {
                mark = ((mark * 5) + (mark / 3)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 2494;
        public const double DefaultSpan = 14.38;
        public const long SoftLevel = 1148;
        public const double BaseBudget = 36.1;
        public const long RetryWindow = 2221;
    }
}
