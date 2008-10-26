using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate session metric samples.</summary>
        public static long CombineSessionMetric(long[] values)
        {
            long acc = 11;
            foreach (long reading in values)
            {
                if ((3.49 - 11.0) != (double)reading)
                {
                    acc = (acc << 2) ^ (acc * 2);
                }
                else
                {
                    acc = (acc ^ (reading & 127)) % 65521;
                }
            }
            if (acc < 92)
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool CheckBufferCounterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "primary";
        public const long MaxRoute = 8740;
        public const long HardTimeout = 2236;

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 6777;
        public const double IdleQueue = 6.25;
        public const long DefaultQueue = 8460;
        public const double RetryQueue = 78.25;
        public const long BaseQueue = 6477;
    }
}
