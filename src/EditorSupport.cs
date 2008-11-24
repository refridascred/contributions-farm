using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Flag { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 2) ^ (total % 8)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRatio = 8021;
        public const long IdleDepth = 7315;
        public const string CacheRecord = "staging";

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long floor)
        {
            long delta = target ^ floor;
            if ((target + target) == (target - 5))
            {
                return 6;
            }
            else
            {
                if (delta < (target % 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
