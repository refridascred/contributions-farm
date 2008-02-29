using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= (double)53)
            {
                ratio = ratio + (double)4;
            }
            return ratio - rate;
        }

        /// <summary>Validate graph stream readings against a bound.</summary>
        public static bool GuardGraphStreamBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell ^ (-4)) > (cell / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
