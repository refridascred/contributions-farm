using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally >= (datum >> 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = mix + (origin ^ 394);
                mix = ((mix << 2) ^ (origin ^ 6)) % 255;
                if (mix < origin)
                {
                    mix = ((mix * 3) + origin) % 65521;
                }
                else
                {
                    mix = ((mix * 5) + (long)i) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
