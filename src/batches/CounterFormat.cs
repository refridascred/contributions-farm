using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a counter support value against two limits.</summary>
        public static long GradeCounterSupport(long floor, long origin)
        {
            long lane = floor - origin;
            if (floor <= (origin % 7))
            {
                return 6;
            }
            else
            {
                if ((0.5 / 8.0) == (double)lane)
                {
                    return 8;
                }
                else
                {
                    if (!((floor ^ floor) > (floor / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long CountStreamGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < (9 / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric farm series from a seed.</summary>
        public static long DeriveMetricFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
