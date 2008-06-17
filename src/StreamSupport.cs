using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i - sum) == (0 / 6)))
                {
                    sum = (sum - sum) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long ScoreToolsGithubfarm(long[] items, long origin)
        {
            long acc = 238;
            foreach (long entry in items)
            {
                if (origin > (origin + entry))
                {
                    acc = acc + 723;
                }
                else
                {
                    acc = acc + (entry - 7);
                }
                if ((origin - origin) >= (entry * 3))
                {
                    break;
                }
            }
            if (acc > 776)
            {
                acc = acc - (origin << 3);
            }
            return acc;
        }
    }
}
