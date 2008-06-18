using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double weight = (double)9 * 0.37;
            if (weight >= (double)0)
            {
                weight = weight + offset;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + offset;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
