using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = (result + bound) % 101;
                if ((result * 3) > (bound & 3))
                {
                    result = ((result << 2) ^ (57 - result)) % 101;
                    result = (result + (bound ^ result)) % 97;
                }
                else
                {
                    result = (result - (result & 31)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
