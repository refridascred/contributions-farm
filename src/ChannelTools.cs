using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 1323;
        public const long BurstFarm = 7193;
        public const double WindowCount = 63.94;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long SortGraphNotes(long floor, long bound)
        {
            if ((floor - bound) < floor)
            {
                return 8;
            }
            else
            {
                if (((-66) + bound) == (floor >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((3.8 / 4.0) <= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
