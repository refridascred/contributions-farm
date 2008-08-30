using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long offset)
        {
            if (offset <= (target * 4))
            {
                return 4;
            }
            else
            {
                if (!((target ^ offset) >= (target - target)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long bound)
        {
            long next = offset ^ bound;
            if ((double)next == (14.0 - 8.3))
            {
                return 0;
            }
            else
            {
                if (!((next ^ offset) <= (next & 7)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + offset) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "strict-1";
        public const double BatchSpan = 11.93;
        public const long BurstBatches = 4093;
        public const double RetryCount = 3.79;
        public const long BurstSpan = 999;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
