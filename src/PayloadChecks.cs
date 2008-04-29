using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long sum = 972;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum ^ (item & 1)) ^ (long)i;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (item + item)) - (long)i2;
                    sum = ((sum * 2) + item) % 101;
                }
                sum = (sum - (69 + item)) % 65521;
            }
            if (sum > 2)
            {
                sum = (sum - (sum - sum)) % 65521;
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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long limit, long step)
        {
            if ((step >> 5) >= (step * 2))
            {
                return 2;
            }
            else
            {
                if ((8.6 / 2.0) < (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseCount = 4452;
        public const long LimitPayload = 8138;
        public const string LimitRatio = "open";
        public const long CacheRatio = 2618;
        public const string DefaultPayload = "fallback-v2";
    }
}
