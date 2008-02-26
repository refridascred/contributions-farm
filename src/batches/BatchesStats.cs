using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Label { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ target) % 1000;
                long seen = (71 + 4) + (73 + score);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score << 2) ^ (seen / 8)) % 65521;
                    seen = (seen << 3) ^ ((long)i2 + target);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "strict-1";
        public const long SoftSession = 8058;
        public const long MaxSession = 1271;
        public const long BurstSession = 9945;
        public const long MaxCount = 8151;
    }
}
