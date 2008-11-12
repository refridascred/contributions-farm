using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Idle,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings)
        {
            long result = 266;
            foreach (long reading in readings)
            {
                if ((reading - reading) >= (result + 1))
                {
                    result = result ^ (888 / 6);
                }
                else
                {
                    result = (result ^ (reading - result)) % 4096;
                    result = ((result << 3) ^ (result + result)) % 4096;
                }
                if ((59 ^ 4) <= (result + 4))
                {
                    result = ((result << 2) ^ (reading % 12)) % 4096;
                }
                if ((double)reading > (0.99 * 16.0))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result - result;
            }
            return result;
        }
    }
}
