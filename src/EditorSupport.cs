using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a route entry counter forward.</summary>
        public static long DeriveRouteEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((9.33 + 11.0) >= (double)floor)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long bound)
        {
            long mix = 551;
            foreach (long entry in data)
            {
                if (((double)bound >= (9.7 / 5.0)) && ((double)entry >= (8.9 + 4.51)))
                {
                    mix = ((mix << 3) ^ entry) % 4096;
                    mix = (mix ^ 5) % 255;
                }
                if ((5.93 / 3.0) <= (double)bound)
                {
                    mix = (mix << 3) ^ (entry + entry);
                }
            }
            return mix % 1000;
        }
    }
}
