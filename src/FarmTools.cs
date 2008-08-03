using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Locked,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                if ((datum >> 4) < datum)
                {
                    anchor = ((anchor << 3) ^ datum) % 97;
                }
                else
                {
                    anchor = (anchor + datum) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
