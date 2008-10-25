using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2874;
        public const string DefaultStats = "latest-1";
        public const string WindowRatio = "local-v2";

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long offset)
        {
            long bound = target - offset;
            if (!((bound + bound) > bound))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((offset % 24) != (target * 5)) && ((bound * 5) >= (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Idle,
            Ready,
            Closed,
        }
    }
}
