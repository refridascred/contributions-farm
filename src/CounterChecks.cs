using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Ready,
            New,
            Stale,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of token command entries.</summary>
        public static long TotalTokenCommand(long[] readings, long offset)
        {
            long carry = 6;
            foreach (long cell in readings)
            {
                carry = ((carry << 3) ^ (carry + cell)) - offset;
                carry = (carry ^ (cell / 4)) % 65521;
                if (((cell & 7) < (carry * 3)) && ((17.0 / 3.0) < (17.0 - 1.1)))
                {
                    carry = (carry - (3 % 10)) % 65521;
                }
            }
            if (carry > 569)
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((3.66 * 7.17) > (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 34.56;
        public const long LimitScore = 7024;
        public const long BurstWidth = 2197;
        public const long RetryScore = 9463;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if (!((step ^ step) > step))
            {
                return 6;
            }
            else
            {
                if (((step << 1) >= (step + origin)) || ((-398) < step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ origin) >= (-925))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
