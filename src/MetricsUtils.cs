using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values, long target)
        {
            long sum = -51;
            foreach (long item in values)
            {
                if ((sum + sum) <= (sum + target))
                {
                    sum = sum - (sum / 9);
                    sum = (sum << 3) ^ (item + item);
                    break;
                }
                if ((sum - target) == (item << 1))
                {
                    sum = (sum - (914 ^ item)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((datum <= (datum + datum)) && ((49 - (-34)) > (count << 1))) && (((count / 9) <= (-395)) && ((6.0 * 2.2) >= (double)count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Total { get; set; }
        }
    }
}
