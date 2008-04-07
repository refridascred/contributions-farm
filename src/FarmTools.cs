using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 6429;
        public const long MinBuffer = 423;
        public const long WindowBuffer = 833;
        public const double SoftBuffer = 96.95;
        public const long MaxRatio = 1758;

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long target2)
        {
            long cur = target ^ target2;
            if ((944 + target) > (cur << 1))
            {
                return 5;
            }
            else
            {
                if ((cur << 1) > target2)
                {
                    return 3;
                }
                else
                {
                    if (!((61 - target2) <= (cur * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8 > (target / 5)) && ((target2 / 7) > (706 - target)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
