using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (((target + target) > (72 + 374)) || ((target - 60) == (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if ((target >= (target + target)) || ((target >> 3) > target))
                {
                    return 5;
                }
                else
                {
                    if (10.0 > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the graph metric series from a seed.</summary>
        public static long DeriveGraphMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (1.9 >= (double)(long)i)
                {
                    mix = (mix + (525 + (long)i)) % 1000;
                    mix = ((mix << 2) ^ (mix >> 2)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
