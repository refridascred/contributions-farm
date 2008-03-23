using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 6) > (5 >> 2))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double scale = (offset - offset) * 9.62;
            if (scale >= offset)
            {
                scale = scale + (scale - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (15.0 - bias);
        }

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long FoldGithubfarmPayload(long[] series, long limit)
        {
            long anchor = 43;
            foreach (long cell in series)
            {
                if ((cell - anchor) > 0)
                {
                    anchor = (anchor - (cell * 2)) % 65521;
                }
                if ((9 ^ limit) < (49 >> 3))
                {
                    anchor = (anchor * 2) + limit;
                }
                if ((cell - cell) > limit)
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor - limit);
            }
            return anchor;
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long OverlapOrderBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
