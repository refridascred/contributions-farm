using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            if (((step & 31) < (step + step)) && (431 < limit))
            {
                return 0;
            }
            else
            {
                if ((18.0 + 3.11) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of support notes readings.</summary>
        public static long TotalSupportNotes(long[] samples, long target)
        {
            long state = 226;
            foreach (long entry in samples)
            {
                state = (((state ^ (state - 40)) % 97) + entry) - target;
            }
            if (state > 11)
            {
                state = state + (396 - state);
            }
            return state;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Queued,
            Draft,
            Paused,
        }
    }
}
