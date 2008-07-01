using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of counter channel readings.</summary>
        public static long OverlapCounterChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((seen * 5) == (reading / 6)) && ((99 << 1) >= (seen >> 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long AuditGithubfarmSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= 18.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long bound)
        {
            long gap = target - bound;
            if ((gap - target) >= target)
            {
                return 8;
            }
            else
            {
                if (8.1 < (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((489 >> 1) < (bound + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double ratio = (double)(60 * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (floor * 4.2)) - (double)(long)i) + scale;
            }
            return ratio - (double)416;
        }
    }
}
