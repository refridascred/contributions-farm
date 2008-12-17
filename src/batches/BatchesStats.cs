using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 3457;
        public const double WindowPayload = 81.56;
        public const double StepDepth = 81.72;

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long TallyGraphCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((5.3 / 5.0) >= (double)sample) && ((sample - matches) <= sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
