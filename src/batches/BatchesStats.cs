using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a record stats value against two limits.</summary>
        public static long RankRecordStats(long origin, long floor)
        {
            if ((floor & 127) == (origin + origin))
            {
                return 4;
            }
            else
            {
                if (((floor * 5) > (floor + origin)) || ((origin ^ 3) >= (origin + floor)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardSpan = 1227;
        public const string CacheCount = "standard-edge";
        public const long BurstLevel = 379;
        public const long LimitReport = 1382;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the checks commits series from a seed.</summary>
        public static long DeriveChecksCommits(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
