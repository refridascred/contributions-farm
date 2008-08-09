using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((20 & 255) != (sum >> 2))
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Roll a commits support counter forward.</summary>
        public static long StepCommitsSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
