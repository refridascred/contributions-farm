using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                total = ((total - (total & 7)) % 1000) - value;
            }
            return total % 65521;
        }

        /// <summary>Audit profile metrics readings against a rule.</summary>
        public static long CountProfileMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((long)items.Length ^ cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
