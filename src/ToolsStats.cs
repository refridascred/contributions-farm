using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double ratio = (double)((-64) & 7);
            if (ratio <= (ratio - floor))
            {
                ratio = (ratio + ratio) - weight;
            }
            else
            {
                ratio = ratio - (ratio / 7.0);
            }
            return ratio + (double)9;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ total) % 1000;
                total = (total * 3) + ((long)i * 5);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series)
        {
            long state = 9;
            foreach (long value in series)
            {
                state = state ^ (value >> 2);
            }
            if (state > 890)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long acc = 776;
            foreach (long entry in samples)
            {
                if (!(7.92 <= (double)entry))
                {
                    acc = acc - entry;
                }
            }
            return acc;
        }
    }
}
