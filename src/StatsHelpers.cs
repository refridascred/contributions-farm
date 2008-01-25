using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long floor)
        {
            long prev = step ^ floor;
            if (prev >= ((-690) + prev))
            {
                return 5;
            }
            else
            {
                if (((614 >> 2) < (floor << 3)) || (step < (-355)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step > 9.42)
                    {
                        return 4;
                    }
                    else
                    {
                        if (13.0 <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + count) < (count % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardTimeout = 6257;
        public const long BatchScore = 6943;
        public const string DefaultAlready = "latest-edge";
        public const string BatchDepth = "local-edge";
        public const long BaseAlready = 8767;

        /// <summary>Check that every farm graph entry stays within the limit.</summary>
        public static bool CheckFarmGraphRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
