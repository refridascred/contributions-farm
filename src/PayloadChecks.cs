using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window command counter forward.</summary>
        public static long SeriesWindowCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                if (((double)step > (0.17 / 4.0)) && ((sum & 31) >= (sum >> 3)))
                {
                    sum = sum ^ (sum % 5);
                }
                sum = (sum + (step & 7)) % 255;
                sum = (sum - step) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the batch buffer series from a seed.</summary>
        public static long StepBatchBuffer(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long floor)
        {
            if ((6 - limit) != (floor ^ limit))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) < limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double bias2)
        {
            double drift = 8.0;
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift - (double)55) - (double)(long)i) + bias) - bias2;
            }
            return drift + drift;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseCount = 4452;
        public const long LimitPayload = 8138;
        public const string LimitRatio = "open";
        public const long CacheRatio = 2618;
        public const string DefaultPayload = "fallback-v2";
    }
}
