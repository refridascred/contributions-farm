using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 64;
            foreach (long sample in items)
            {
                if ((anchor ^ sample) <= anchor)
                {
                    anchor = anchor - 9;
                }
                if (anchor > sample)
                {
                    anchor = (anchor ^ (anchor * 4)) % 4096;
                }
            }
            if (anchor > 738)
            {
                anchor = anchor - (anchor % 5);
            }
            return anchor;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next layout batches value.</summary>
        public static double BlendLayoutBatches(double rate, double span)
        {
            double load = span * 5.0;
            if (load > (load * 14.0))
            {
                load = load + (rate * 5.0);
            }
            else
            {
                load = load - rate;
            }
            return load - load;
        }
    }
}
