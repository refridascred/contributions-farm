using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings, long seed)
        {
            long total = 61;
            foreach (long value in readings)
            {
                total = ((total ^ (56 - 1)) % 255) + seed;
                if ((value + total) < (value & 127))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Draft,
            New,
        }

        /// <summary>Locate a counter order reading by value.</summary>
        public static long SeekCounterOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first buffer token entry that matches the target.</summary>
        public static long FindBufferTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            Draft,
        }
    }
}
