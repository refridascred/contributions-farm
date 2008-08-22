using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every batches metrics entry stays within the limit.</summary>
        public static bool GuardBatchesMetricsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long origin)
        {
            long prev = step + origin;
            if ((0.33 - 2.68) == (double)prev)
            {
                return 8;
            }
            else
            {
                if ((double)step < (1.36 - 4.5))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
