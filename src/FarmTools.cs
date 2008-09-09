using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Ready,
            Failed,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count ^ item) > (count - (-20)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
