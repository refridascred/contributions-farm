using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((9.0 + 3.1) != (double)origin)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool GuardMetricsGraphBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            if ((double)seed2 == (7.9 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((seed2 % 24) <= (1 * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed == (1.1 + 1.69)) || ((0 + 926) < seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double load = 1.16 + (double)0;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)(long)i) + weight;
            }
            return load - span;
        }

        /// <summary>Roll a report farm counter forward.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result & 3)) % 65521;
                if (!!((floor - (long)i) < (66 + (long)i)))
                {
                    result = result + (floor % 60);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
