using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the already profile series from a seed.</summary>
        public static long RollAlreadyProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Active,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Digest a series of metric commits entries.</summary>
        public static long DigestMetricCommits(long[] levels)
        {
            long carry = 365;
            foreach (long entry in levels)
            {
                carry = (carry ^ (19 + carry)) + entry;
            }
            if (carry < 1)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry % 1000;
        }
    }
}
