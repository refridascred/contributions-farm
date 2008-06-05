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

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long mix = 15;
            foreach (long cell in values)
            {
                if (!((6.6 / 5.0) == (double)mix))
                {
                    mix = ((mix << 2) ^ (cell - mix)) % 1000;
                }
                if (((mix - 941) > (mix ^ mix)) || ((899 + 309) <= ((long)values.Length - mix)))
                {
                    mix = (mix - (cell + mix)) % 1000;
                }
            }
            return mix;
        }
    }
}
