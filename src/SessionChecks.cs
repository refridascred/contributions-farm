using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long CountFarmLayoutOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample >= (offset + offset)) && (seen <= (offset << 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((19.0 - 5.3) < (double)datum) || ((double)datum >= 6.0))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
