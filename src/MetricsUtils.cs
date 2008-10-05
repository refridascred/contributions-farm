using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "staging-edge";
        public const double MinCount = 61.35;
        public const double SoftCount = 13.97;
        public const double IdleStats = 29.68;
        public const long BatchStats = 7417;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 15;
            foreach (long reading in items)
            {
                if ((double)reading >= 4.5)
                {
                    score = (score ^ score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry editor samples are out of range.</summary>
        public static long MeasureEntryEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)limit < 7.0) || ((datum & 1) >= (limit + limit)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Closed,
            Stale,
        }
    }
}
