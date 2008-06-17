using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)result > (double)3)
                {
                    result = (result ^ ((long)i + 973)) % 1000;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long step)
        {
            long span = floor - step;
            if (((floor + 10) < (floor & 255)) || ((double)span > (double)floor))
            {
                return 4;
            }
            else
            {
                if ((span + floor) >= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 1) > (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
