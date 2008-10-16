using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
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
