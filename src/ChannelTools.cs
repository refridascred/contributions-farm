using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "stable";
        public const long MinFactor = 7496;
        public const long MinSpan = 2558;
        public const string StepSize = "stable";

        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long MeasureReportBatchMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((184 + matches) <= origin)
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > ((long)i % 97))
                {
                    sum = ((sum * 4) + (bound + 16)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
