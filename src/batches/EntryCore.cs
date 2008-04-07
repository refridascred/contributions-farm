using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next buffer session value from a seed.</summary>
        public static long DeriveBufferSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum + sum);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardLevel = 3898;
        public const long BaseInterval = 6688;
        public const long HardCount = 8289;
    }
}
