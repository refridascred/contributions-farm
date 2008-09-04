using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long MeasureSchemaNotesMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed ^ sample) >= (count ^ sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long bound)
        {
            long mark = 663;
            foreach (long datum in series)
            {
                if ((bound & 7) > (long)series.Length)
                {
                    mark = ((mark << 3) ^ (datum & 7)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 901;
        public const long DefaultLevel = 308;
        public const long RetrySize = 7292;
        public const double BaseGraph = 14.8;
    }
}
