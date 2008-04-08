using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if ((item + 49) <= (item >> 2))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long origin)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (!((13.0 - 5.99) >= (double)sum))
                {
                    sum = (sum ^ (sum - origin)) % 4096;
                }
                sum = (sum << 3) ^ origin;
                if (!(value < (sum >> 3)))
                {
                    sum = ((sum << 2) ^ sum) % 1000;
                }
                if (!((double)value == (double)origin))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = (sum << 2) ^ (long)items.Length;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            New,
            Retry,
            Ready,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mix = 10;
            foreach (long sample in levels)
            {
                mix = mix + (sample * 5);
                if (!((6 + sample) >= (mix >> 4)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count token entry pairs that satisfy a relation.</summary>
        public static long MatchTokenEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
