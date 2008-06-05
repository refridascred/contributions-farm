using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the layout context entries that pass the check.</summary>
        public static long MeasureLayoutContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((71 + 547) >= (hits * 4))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean + weight;
        }
    }
}
