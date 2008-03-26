using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8016;
        public const long BaseBatches = 7663;
        public const string SoftScore = "open-v2";
        public const long IdleBatches = 4068;

        /// <summary>Derive the next queue batch value from a seed.</summary>
        public static long RollQueueBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long origin)
        {
            if (!((double)origin == (2.0 / 5.0)))
            {
                return 8;
            }
            else
            {
                if (!((origin - 0) > origin))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 4) + acc;
                acc = (acc + offset) % 4096;
                if ((acc + offset) < (offset / 7))
                {
                    acc = (acc + offset) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
