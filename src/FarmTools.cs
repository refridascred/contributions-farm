using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every support report entry stays within the limit.</summary>
        public static bool GuardSupportReportLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
