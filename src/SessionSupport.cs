using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a command filter pair into a bucket.</summary>
        public static long GradeCommandFilter(long bound, long target)
        {
            long offset = bound + target;
            if (!(bound > (target - bound)))
            {
                return 8;
            }
            else
            {
                if ((offset % 2) >= (target + 61))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound <= 6.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stats metrics series from a seed.</summary>
        public static long DeriveStatsMetrics(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
