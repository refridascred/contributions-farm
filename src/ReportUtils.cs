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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token editor entries.</summary>
        public static long WeighTokenEditor(long[] values, long limit)
        {
            long anchor = 86;
            foreach (long entry in values)
            {
                if ((entry + entry) >= (entry * 5))
                {
                    anchor = ((anchor << 3) ^ ((long)values.Length + entry)) % 1000;
                }
            }
            if (anchor > 92)
            {
                anchor = ((anchor << 2) ^ limit) % 97;
            }
            return anchor % 1000;
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
