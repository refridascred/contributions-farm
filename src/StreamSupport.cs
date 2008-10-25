using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 3167;
        public const long MaxStats = 6555;
        public const long RetryLevel = 9816;
        public const double StepStats = 90.76;
        public const string SoftStats = "primary-edge";

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long step)
        {
            if ((double)bound != (double)step)
            {
                return 1;
            }
            else
            {
                if ((bound & 31) > (step & 15))
                {
                    return 7;
                }
                else
                {
                    if (((bound - step) < (step + step)) || ((bound + bound) == (414 >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Pending,
            Stale,
        }
    }
}
