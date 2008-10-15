using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate account farm samples.</summary>
        public static long FoldAccountFarm(long[] values, long bound)
        {
            long score = 125;
            foreach (long entry in values)
            {
                if (!((double)bound < 0.74))
                {
                    score = ((score << 3) ^ (entry >> 5)) % 4096;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long mark = 520;
            foreach (long sample in readings)
            {
                mark = (mark ^ (mark + (long)readings.Length)) % 4096;
                if (((mark % 64) == (limit / 8)) || ((81 + mark) < ((long)readings.Length * 2)))
                {
                    mark = (mark * 4) + (mark - mark);
                }
                if ((limit & 15) < (limit + limit))
                {
                    mark = mark - sample;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
