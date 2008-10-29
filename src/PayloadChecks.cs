using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metric entry entry that matches the target.</summary>
        public static long SeekMetricEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Active,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] data, long floor)
        {
            long carry = 176;
            foreach (long reading in data)
            {
                if ((reading & 127) >= (floor - reading))
                {
                    carry = ((carry * 2) + (carry & 15)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (carry & 7)) % 255;
                }
                if ((7.0 * 3.91) < (double)reading)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
