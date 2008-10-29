using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((51 + step) > step)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Pending,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data, long offset)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if (!(result > ((-8) - (long)data.Length)))
                {
                    result = ((result + 26) % 1000) + datum;
                }
                if (result > (offset + offset))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double ratio = 7.46;
            return (ratio - (offset * 6.0)) + scale;
        }
    }
}
