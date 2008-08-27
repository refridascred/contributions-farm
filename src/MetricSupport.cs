using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long DigestGraphCounter(long[] items)
        {
            long sum = 44;
            foreach (long item in items)
            {
                if ((sum - sum) < ((long)items.Length - sum))
                {
                    sum = (sum - (item - 770)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of command filter readings.</summary>
        public static long WeighCommandFilter(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = ((total * 3) + total) % 97;
                total = total + item;
                if ((total % 10) > item)
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Stale,
            Active,
        }
    }
}
