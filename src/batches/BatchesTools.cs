using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Pending,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of notes stream entries.</summary>
        public static long WeighNotesStream(long[] series)
        {
            long mix = 628;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix - (sample >> 5)) % 255;
                    mix = (mix + ((long)i + sample)) % 101;
                }
                if ((sample & 255) > (25 & 15))
                {
                    mix = (mix << 3) ^ (mix ^ (-5));
                }
            }
            return mix;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset / 9) == (478 + 74))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                    anchor = ((anchor * 5) + (anchor + 5)) % 1000;
                }
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
