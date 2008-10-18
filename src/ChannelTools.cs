using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxLevel = 6010;
        public const long StepCache = 4977;
        public const double MinTimeout = 19.03;
        public const double LimitDepth = 58.12;
        public const long MinCache = 5984;

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
