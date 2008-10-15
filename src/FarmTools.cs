using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Closed,
            Ready,
            Stale,
        }

        /// <summary>Iterate the contributi buffer series from a seed.</summary>
        public static long StepContributiBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
