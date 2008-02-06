using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 7;
            foreach (long value in items)
            {
                score = score + 87;
                if (((value / 2) > (value << 3)) || ((2 ^ score) < (value ^ (-6))))
                {
                    score = (score * 4) + 14;
                }
            }
            return score;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
