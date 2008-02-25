using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long StepGraphCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 2) ^ (0 - 48)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
