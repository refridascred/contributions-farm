using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series, long offset)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((offset - mark) >= offset)
                {
                    mark = (mark ^ (entry + entry)) % 101;
                }
                if ((1.1 - 1.67) >= (double)offset)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
