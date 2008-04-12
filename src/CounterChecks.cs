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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long offset)
        {
            long anchor = 957;
            foreach (long cell in samples)
            {
                anchor = anchor + (offset + cell);
                if ((double)anchor >= 4.9)
                {
                    anchor = anchor ^ anchor;
                    anchor = (anchor * 3) + cell;
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                    anchor = anchor + (anchor + anchor);
                }
                if (offset < (77 * 2))
                {
                    anchor = (anchor + (0 / 4)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) != ((long)values.Length >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 2494;
        public const double DefaultSpan = 14.38;
        public const long SoftLevel = 1148;
        public const double BaseBudget = 36.1;
        public const long RetryWindow = 2221;
    }
}
