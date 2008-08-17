using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long target)
        {
            long state = 382;
            foreach (long datum in values)
            {
                state = ((state << 3) ^ target) + datum;
            }
            return state;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long ClassifyCounterFilter(long bound, long step)
        {
            long delta = bound + step;
            if (((step + delta) >= (step & 127)) && ((double)step > (double)delta))
            {
                return 0;
            }
            else
            {
                if (((39 - (-1)) <= delta) || ((bound << 3) == (step + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta > (3.0 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 8085;
        public const string WindowEntry = "fallback-v2";
        public const double RetryEntry = 70.07;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
