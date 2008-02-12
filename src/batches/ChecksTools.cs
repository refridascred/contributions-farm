using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of schema already entries.</summary>
        public static long DigestSchemaAlready(long[] levels)
        {
            long mark = 5;
            foreach (long sample in levels)
            {
                if ((mark >> 4) > sample)
                {
                    mark = (mark - (1 ^ 6)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
