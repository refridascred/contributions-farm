using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long CountGraphContextMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + floor) > (tally + (-103)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the already window series from a seed.</summary>
        public static long RollAlreadyWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 4096) + (long)i2;
                }
                anchor = (anchor + (seed % 100)) % 1000;
                if (((anchor & 15) >= (seed + anchor)) && ((double)anchor < (double)seed))
                {
                    anchor = anchor ^ (anchor / 4);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Queued,
            Paused,
            Active,
        }
    }
}
