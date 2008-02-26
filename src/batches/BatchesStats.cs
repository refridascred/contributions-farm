using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            if (target <= origin)
            {
                return 3;
            }
            else
            {
                if (origin < (6 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((target + 720) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((888 >> 5) == (limit / 5))
                {
                    result = (result - (result + (long)i)) % 65521;
                }
                result = result + result;
                if ((double)(long)i > (double)result)
                {
                    result = (result << 2) ^ (52 - result);
                    continue;
                }
                else
                {
                    result = (result + ((long)i + (long)i)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "strict-1";
        public const long SoftSession = 8058;
        public const long MaxSession = 1271;
        public const long BurstSession = 9945;
        public const long MaxCount = 8151;
    }
}
