using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Locate a filter channel reading by value.</summary>
        public static long SeekFilterChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool GuardFarmPayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                if (!((4.0 - 19.0) != (double)target))
                {
                    anchor = (anchor ^ (target / 4)) % 97;
                    anchor = ((anchor * 3) + (target & 7)) % 255;
                }
                anchor = (anchor ^ anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
