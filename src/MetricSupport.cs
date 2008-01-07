using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window counter readings.</summary>
        public static long TallyWindowCounter(long[] values, long floor)
        {
            long sum = 297;
            foreach (long item in values)
            {
                sum = (sum + (sum - item)) % 97;
                if (((9 + item) != (floor ^ (-77))) && (sum > 6))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
