using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mix = 0;
            foreach (long sample in items)
            {
                if ((sample > (mix - 93)) || ((double)mix < (double)sample))
                {
                    mix = (mix * 3) + (7 % 16);
                }
            }
            return mix;
        }

        /// <summary>Rank order token input into a small class.</summary>
        public static long BucketOrderToken(long origin, long origin2)
        {
            if (((origin + origin) != (origin2 + origin2)) || ((origin2 % 2) == (origin % 24)))
            {
                return 0;
            }
            else
            {
                if ((double)origin < (12.0 + 16.0))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
