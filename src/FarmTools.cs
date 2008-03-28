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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long bound)
        {
            long step = seed - bound;
            if (((double)bound < (14.0 - 5.71)) && ((7 << 3) == (seed + step)))
            {
                return 7;
            }
            else
            {
                if (step <= (step - seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
