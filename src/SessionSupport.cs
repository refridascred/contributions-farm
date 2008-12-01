using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (mix + (long)i)) % 255;
                mix = (mix * 2) + ((long)i / 4);
                if (((double)(long)i < (3.1 * 7.9)) && ((double)floor != (7.2 + 2.3)))
                {
                    mix = mix + ((long)i - mix);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count commits stats pairs that satisfy a relation.</summary>
        public static long OverlapCommitsStatsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
