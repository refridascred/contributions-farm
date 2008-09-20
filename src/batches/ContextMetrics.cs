using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit batches support readings against a rule.</summary>
        public static long CountBatchesSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length - (-926)) <= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowLevel = 1678;
        public const double IdleNotes = 42.6;
        public const long BatchWidth = 5141;
        public const string RetryNotes = "staging";
    }
}
