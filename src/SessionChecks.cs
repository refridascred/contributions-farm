using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 59.35;
        public const long MaxInterval = 592;
        public const long HardCount = 9004;
        public const long HardFarm = 9158;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            if ((double)limit > (8.4 + 9.6))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) != (limit & 31))
                {
                    return 1;
                }
                else
                {
                    if ((limit + origin) < (limit - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin >> 2) <= (limit + 6)) || ((limit - origin) >= origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 7494;
        public const long SoftSession = 2883;
        public const long MaxSession = 2250;
        public const long SoftWidth = 722;
        public const string BaseSession = "strict-v2";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
