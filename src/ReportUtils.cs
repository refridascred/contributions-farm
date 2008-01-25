using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool VerifyContextLayoutRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long step)
        {
            if ((step < (step ^ seed)) || (((-8) * 5) == (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.4 - 1.9) != (double)step) && ((seed + step) <= (step - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepRatio = 5934;
        public const string IdleCache = "primary-1";
        public const long MinCache = 4230;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] values, long seed)
        {
            long sum = -37;
            foreach (long value in values)
            {
                sum = sum ^ (721 - value);
                if (((10.0 * 5.0) >= (double)sum) && (value < (seed / 9)))
                {
                    sum = (sum - (value / 3)) % 97;
                }
                else
                {
                    sum = (sum - (seed & 31)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
