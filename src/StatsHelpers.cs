using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double gain = ratio;
            if (gain > gain)
            {
                gain = (gain + (double)16) - bias;
            }
            return gain + gain;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a entry tools reading by value.</summary>
        public static long SeekEntryToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }
    }
}
