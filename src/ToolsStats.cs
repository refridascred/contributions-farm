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

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public bool Label { get; set; }
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
