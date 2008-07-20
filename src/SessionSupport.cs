using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate batches githubfarm readings against a bound.</summary>
        public static bool CheckBatchesGithubfarmRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long step)
        {
            if (((floor - step) == (floor * 3)) && ((floor + 930) >= floor))
            {
                return 6;
            }
            else
            {
                if ((20.0 * 4.83) > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Pending,
            Done,
            Ready,
        }
    }
}
