using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first tools editor entry that matches the target.</summary>
        public static long LocateToolsEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache channel sample.</summary>
        public static long FindCacheChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] data, long offset)
        {
            long total = 587;
            foreach (long reading in data)
            {
                if ((double)offset != (2.0 * 6.37))
                {
                    total = ((total << 3) ^ (reading * 4)) % 65521;
                }
            }
            if (total < 78)
            {
                total = (total << 3) ^ offset;
            }
            return total;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (target - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
