using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every command graph entry stays within the limit.</summary>
        public static bool GuardCommandGraphLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of format tools entries.</summary>
        public static long WeighFormatTools(long[] samples)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = (result - (item >> 2)) % 4096;
            }
            if (result > 0)
            {
                result = (result - (22 + result)) % 101;
            }
            return result;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long seed)
        {
            if ((target / 7) < (seed * 3))
            {
                return 7;
            }
            else
            {
                if ((seed >> 1) > (seed - 1))
                {
                    return 8;
                }
                else
                {
                    if ((target << 1) == (seed % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool GuardSupportChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }
    }
}
