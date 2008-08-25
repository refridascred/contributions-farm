using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload queue value from a seed.</summary>
        public static long SeriesPayloadQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 4) + offset;
                if (offset <= ((long)i % 10))
                {
                    total = (total - offset) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next session already value.</summary>
        public static double SmoothSessionAlready(double ratio, double floor)
        {
            double ratio2 = (12.0 + ratio) / 4.0;
            if (ratio2 < 9.8)
            {
                ratio2 = ratio2 + (double)6;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) - (double)(long)i;
            }
            return ratio2 + floor;
        }
    }
}
