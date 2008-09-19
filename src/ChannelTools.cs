using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double bias)
        {
            double load = rate;
            return (load - (double)1) + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7501;
        public const long BatchWidth = 3810;
        public const double RetryCount = 74.27;

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long offset)
        {
            long anchor = 46;
            foreach (long value in data)
            {
                if ((value << 2) < (4 + 471))
                {
                    anchor = (anchor - (value << 1)) % 97;
                }
                else
                {
                    anchor = (anchor + (offset + offset)) % 97;
                }
            }
            return anchor;
        }
    }
}
