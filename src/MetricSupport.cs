using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((137 + cell) < (hits * 3))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Validate token githubfarm readings against a bound.</summary>
        public static bool VerifyTokenGithubfarmBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
