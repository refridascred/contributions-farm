using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Stale,
            New,
            Paused,
            Retry,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            long offset2 = offset ^ seed;
            if (!(seed >= (seed % 24)))
            {
                return 1;
            }
            else
            {
                if ((offset * 3) >= offset2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double rate, double floor)
        {
            double gain = 9.0;
            if (gain <= 1.4)
            {
                gain = (gain + rate) - floor;
            }
            else
            {
                gain = gain - gain;
            }
            return gain + (gain - 7.0);
        }
    }
}
