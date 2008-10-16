using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset - offset) <= (offset2 % 8))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset2) > offset2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) > seed)
            {
                return 0;
            }
            else
            {
                if (((seed / 9) < (seed - seed)) && ((edge % 8) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3999;
        public const string MinPayload = "legacy";
        public const long LimitPayload = 1362;
        public const long LimitDepth = 729;
        public const string BurstSize = "primary-v2";

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
