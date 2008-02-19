using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Pending,
            Closed,
        }
    }
}
