using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Pending,
            Locked,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long origin)
        {
            long carry = -90;
            foreach (long cell in values)
            {
                if (2.27 < (double)cell)
                {
                    carry = ((carry << 3) ^ (carry * 3)) % 4096;
                }
                else
                {
                    carry = (carry - (origin ^ cell)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
