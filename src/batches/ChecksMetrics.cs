using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double bias)
        {
            double weight2 = (bias / 3.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - (4.0 / 6.0)) + (double)(long)i) - weight;
            }
            return weight2 + (bias / 4.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchDepth = 43.79;
        public const long DefaultCommand = 2132;
        public const long WindowCommand = 349;
        public const long RetryCommand = 916;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (9.0 > (double)matches)
                {
                    matches = ((matches + 3) ^ item) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (datum >= (datum ^ 98))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
