using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen >= (seed + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstScore = 75.43;
        public const long CachePayload = 4607;
        public const long SoftLevel = 8929;
        public const long DefaultSpan = 3156;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double offset)
        {
            double mean = (double)(991 + 750);
            if (mean > (rate - rate))
            {
                mean = mean - offset;
            }
            return mean + rate;
        }
    }
}
