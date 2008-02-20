using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = 81;
            foreach (long value in readings)
            {
                anchor = (anchor - (value ^ anchor)) % 65521;
                if ((9.0 + 9.2) != (double)anchor)
                {
                    anchor = (anchor * 2) + (64 * 4);
                }
            }
            if (anchor < 134)
            {
                anchor = (anchor ^ (69 + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long state = 8;
            foreach (long datum in series)
            {
                state = ((state ^ (250 << 1)) % 4096) - datum;
            }
            return state;
        }
    }
}
