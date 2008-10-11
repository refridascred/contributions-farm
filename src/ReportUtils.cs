using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double load = span;
            if (load <= (span - span))
            {
                load = (load - load) - scale;
            }
            else
            {
                load = load + load;
            }
            return load - (load / 9.0);
        }

        /// <summary>Measure how many commits tools samples are out of range.</summary>
        public static long CountCommitsToolsMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits % 16) <= (hits + reading)) && (((18.0 - 2.0) == (double)hits) && (hits >= (origin - reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch editor value against two limits.</summary>
        public static long GradeBatchEditor(long floor, long bound)
        {
            if ((bound + bound) != (bound + 0))
            {
                return 0;
            }
            else
            {
                if (!((double)bound != (6.8 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor > (bound << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(6.0 > (double)floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
