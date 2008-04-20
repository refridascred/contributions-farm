using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ 90) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 6;
            foreach (long sample in data)
            {
                if ((sample % 12) <= (score * 5))
                {
                    score = (score ^ sample) % 255;
                }
            }
            return score;
        }
    }
}
