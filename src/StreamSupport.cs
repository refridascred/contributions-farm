using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((93 & 15) == (long)i)
                {
                    total = total + seed;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mix = 82;
            foreach (long datum in levels)
            {
                mix = (mix ^ origin) % 4096;
                mix = (mix - (datum - mix)) % 1000;
                mix = (mix * 2) + (datum + mix);
            }
            return mix % 1000;
        }
    }
}
