using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token commits value against two limits.</summary>
        public static long GradeTokenCommits(long origin, long limit)
        {
            if (((origin / 9) <= (origin ^ origin)) || ((limit + limit) != (origin % 16)))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) < limit)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
