using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long floor, long floor2)
        {
            if (6.7 < (double)floor)
            {
                return 4;
            }
            else
            {
                if (floor <= (floor & 127))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 + floor2) < (floor2 << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)floor2 == (15.0 - 1.2)) && (floor2 <= (floor2 >> 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile session value from a seed.</summary>
        public static long StepProfileSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double weight = 8.0;
            if (weight < (double)(-5))
            {
                weight = (weight - (double)73) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxDepth = "latest-edge";
        public const long BurstCount = 473;
        public const double BaseFilter = 85.08;
        public const long WindowFilter = 7285;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((648 - tally) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
