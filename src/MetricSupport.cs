using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((638 + 5) < (floor << 2))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long CountAlreadyClusterHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(sample >= (hits * 3)))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }
    }
}
