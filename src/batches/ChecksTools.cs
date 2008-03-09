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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = acc - (target & 63);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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
