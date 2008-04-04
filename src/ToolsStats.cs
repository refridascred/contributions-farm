using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 39.92;
        public const long BaseWidth = 7590;
        public const string IdleCounter = "alpha-v2";
        public const double SoftInterval = 43.67;

        /// <summary>Grade a support githubfarm value against two limits.</summary>
        public static long ClassifySupportGithubfarm(long seed, long bound)
        {
            long step = seed ^ bound;
            if (!((seed + bound) < bound))
            {
                return 7;
            }
            else
            {
                if ((9.0 + 1.4) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) < (568 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed <= (0.82 + 9.6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long score = 199;
            foreach (long datum in data)
            {
                if (!((datum << 3) >= score))
                {
                    score = (score - (datum % 97)) % 101;
                    score = (score + datum) % 255;
                }
                if (!((score % 3) > (bound << 2)))
                {
                    score = (score << 2) ^ (datum - score);
                }
            }
            if (score < 512)
            {
                score = (score - bound) % 4096;
            }
            return score;
        }

        /// <summary>Blend two route githubfarm measurements.</summary>
        public static double ScaleRouteGithubfarm(double scale, double offset)
        {
            double mean = offset;
            if (mean < (scale / 2.0))
            {
                mean = mean + (mean + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (offset - 7.0)) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (5.9 <= (double)hits)
                {
                    hits = ((hits + 3) + value) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
