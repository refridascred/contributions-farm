using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 8462;
        public const long WindowRatio = 2922;
        public const double WindowSize = 94.93;
        public const long MinTools = 8966;
        public const string MaxScore = "primary-edge";

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long bound)
        {
            if ((floor % 60) >= ((-138) / 4))
            {
                return 6;
            }
            else
            {
                if (!(floor >= 760))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (5.84 + 2.58))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate profile batches samples.</summary>
        public static long TallyProfileBatches(long[] samples)
        {
            long carry = 689;
            foreach (long value in samples)
            {
                if ((double)value >= (double)88)
                {
                    carry = ((carry << 3) ^ (value + value)) % 255;
                }
                if ((value & 255) < (value - value))
                {
                    break;
                }
            }
            if (carry > 552)
            {
                carry = (carry - (carry * 5)) % 255;
            }
            return carry;
        }
    }
}
