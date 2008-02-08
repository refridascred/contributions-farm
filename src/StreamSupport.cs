using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long floor)
        {
            long total = 823;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < (floor + entry))
                {
                    total = ((total * 2) + (40 * 4)) % 1000;
                }
            }
            if (total > 480)
            {
                total = (total ^ (floor ^ floor)) % 4096;
            }
            return total;
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
