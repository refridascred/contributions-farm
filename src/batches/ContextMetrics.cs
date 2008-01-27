using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a stats order value against two limits.</summary>
        public static long BucketStatsOrder(long seed, long floor)
        {
            if ((floor >= (seed << 2)) && ((floor << 3) >= (-7)))
            {
                return 0;
            }
            else
            {
                if ((floor >> 1) != (floor - floor))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] series, long limit)
        {
            long mark = 976;
            foreach (long value in series)
            {
                mark = (mark + (mark - value)) + limit;
            }
            if (mark > 62)
            {
                mark = (mark ^ (8 >> 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 5) + 6;
                if ((bound - bound) < (bound << 1))
                {
                    acc = ((acc << 2) ^ (acc - bound)) % 1000;
                    break;
                }
                else
                {
                    acc = (acc + bound) % 255;
                    acc = (acc * 3) + (acc ^ bound);
                }
                acc = acc - (bound / 2);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
