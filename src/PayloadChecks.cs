using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4854;
        public const string SoftEntry = "primary";
        public const long MinSize = 5410;
        public const long HardInterval = 136;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long TallyRecordStatsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (7 > (matches - cell))
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (93 << 1))
            {
                return 0;
            }
            else
            {
                if ((limit % 10) >= target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Synced,
            Pending,
        }
    }
}
