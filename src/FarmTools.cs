using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool CheckContributiAccountLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Failed,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long seed)
        {
            if ((double)origin < (double)761)
            {
                return 2;
            }
            else
            {
                if (((seed + 939) == (seed & 7)) || (origin <= 17))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
