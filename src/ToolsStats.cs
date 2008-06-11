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

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data, long target)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (((-308) ^ target) >= (0 - target))
                {
                    mark = (mark ^ (sample ^ 24)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
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
