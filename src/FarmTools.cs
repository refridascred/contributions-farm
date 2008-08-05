using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long CountCounterSupportOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((1 * 2) >= (limit - item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long RollBatchSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = (result + ((long)i ^ (long)i)) % 1000;
                result = (result + floor) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
