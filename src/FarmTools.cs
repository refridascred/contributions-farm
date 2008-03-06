using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long bound, long floor)
        {
            if ((209 + floor) < 4)
            {
                return 4;
            }
            else
            {
                if ((double)bound < (15.0 * 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 31) == (floor & 63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7680;
        public const long BurstRoute = 4076;
        public const long MaxRoute = 5142;
        public const double SoftRoute = 97.58;
        public const long HardWidth = 4882;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
