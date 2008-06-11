using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(origin >= (origin / 2)))
                {
                    score = ((score << 3) ^ (score ^ score)) % 97;
                }
                if ((long)i != ((long)i + score))
                {
                    score = ((score * 2) + (origin & 255)) % 97;
                    score = score - ((long)i + origin);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Weight { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)origin >= (0.1 / 4.0))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a githubfarm profile figure with a bias.</summary>
        public static double ProjectGithubfarmProfile(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= 10.0)
            {
                ratio2 = ratio2 + (double)63;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (bias + 9.2)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + 7.0);
        }
    }
}
