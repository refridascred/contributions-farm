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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry / 3) >= (count & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
