using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((2.0 / 6.0) > (double)matches) && ((double)limit >= (double)64))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
