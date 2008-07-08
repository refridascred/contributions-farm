using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value >= (value % 100)) && ((value >> 4) < (8 ^ 970)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "strict-edge";
        public const long BaseInterval = 9125;
        public const long HardBatch = 7324;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                if (!(((value - value) == (score << 3)) || ((score % 7) >= (score ^ value))))
                {
                    score = score + (score + score);
                }
                if ((value - value) < value)
                {
                    score = ((score * 2) + (score % 8)) % 4096;
                }
            }
            return score;
        }
    }
}
