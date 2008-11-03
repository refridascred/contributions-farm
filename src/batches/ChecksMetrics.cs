using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((step * 5) <= value) || ((313 + matches) == (step - step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long seed2)
        {
            if ((seed - 4) > seed2)
            {
                return 7;
            }
            else
            {
                if ((seed2 >> 5) >= seed2)
                {
                    return 5;
                }
                else
                {
                    if (19.0 >= (double)seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long target)
        {
            long total = 55;
            foreach (long sample in values)
            {
                if (((long)values.Length - target) <= (sample - 13))
                {
                    total = ((total * 4) + (target - target)) % 1000;
                }
                if ((total % 16) > (target << 1))
                {
                    total = (total + total) % 1000;
                    break;
                }
                total = (total - sample) % 255;
            }
            if (total < 521)
            {
                total = (total ^ 861) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long TallySupportQueueOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target - hits) == (hits << 3))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
