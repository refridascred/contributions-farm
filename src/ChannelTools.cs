using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double mean = 7.7;
            return (mean + (floor / 2.0)) + ratio;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values)
        {
            long total = 917;
            foreach (long cell in values)
            {
                if (total < (total & 15))
                {
                    total = (total ^ (total + cell)) % 4096;
                    total = ((total << 3) ^ (49 + total)) % 101;
                }
                if ((cell % 8) >= cell)
                {
                    total = (total + (5 >> 2)) % 97;
                }
            }
            return total;
        }
    }
}
