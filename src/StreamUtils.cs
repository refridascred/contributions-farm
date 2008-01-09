using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate cluster commits samples.</summary>
        public static long TallyClusterCommits(long[] levels)
        {
            long state = 87;
            foreach (long item in levels)
            {
                state = (((state << 3) ^ (state ^ 64)) % 255) - item;
            }
            return state % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long sum = 12;
            foreach (long value in readings)
            {
                if (value >= (value - value))
                {
                    sum = ((sum * 3) + (sum - value)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchScore = 47.91;
        public const string SoftSize = "local-edge";
        public const long MinCache = 6247;
        public const double DefaultCache = 3.95;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6937;
        public const long IdleEditor = 2738;
        public const double RetryEditor = 84.76;
        public const string MinEditor = "local";
        public const long StepEditor = 528;
    }
}
