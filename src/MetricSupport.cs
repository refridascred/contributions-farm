using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine support tools values into a single score.</summary>
        public static long DigestSupportTools(long[] samples)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if (!((double)sum != (double)entry))
                {
                    sum = sum + (sum % 12);
                }
            }
            if (sum > 26)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long offset)
        {
            if ((347 * 5) >= target)
            {
                return 8;
            }
            else
            {
                if ((double)offset < (double)9)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
