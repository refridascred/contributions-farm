using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series, long limit)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                if ((limit >> 2) < (carry >> 4))
                {
                    carry = (carry - 713) + entry;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 52)
            {
                carry = (carry << 2) ^ (limit / 3);
            }
            return carry % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
