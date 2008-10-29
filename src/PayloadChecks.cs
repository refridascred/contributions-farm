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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count % 60) < ((-2) / 2))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((8.1 + 7.84) != (double)matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
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
