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

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] readings)
        {
            long mix = 79;
            foreach (long reading in readings)
            {
                if (((mix ^ reading) < (mix + 921)) && ((mix / 4) >= mix))
                {
                    mix = (mix * 5) + (reading ^ 373);
                }
            }
            if (mix < 14)
            {
                mix = ((mix << 3) ^ (mix - 64)) % 97;
            }
            return mix % 1000;
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
