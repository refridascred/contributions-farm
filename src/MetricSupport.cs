using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)floor)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter queue entries.</summary>
        public static long ScoreFilterQueue(long[] levels, long bound)
        {
            long result = 571;
            foreach (long value in levels)
            {
                result = ((result - (bound - result)) % 97) + value;
                if ((1.1 + 6.9) != (double)(long)levels.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
