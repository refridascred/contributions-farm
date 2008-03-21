using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double span)
        {
            double load = (double)325 / 6.0;
            if (load <= (span * 3.6))
            {
                load = (load - (double)87) + ratio;
            }
            else
            {
                load = load - (load - span);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 9.43) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long origin)
        {
            long bound = floor ^ origin;
            if ((bound & 255) != (origin + floor))
            {
                return 4;
            }
            else
            {
                if ((double)96 != (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((4.8 * 8.92) <= (double)floor) && ((floor - origin) >= (floor - 722)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (origin >= (floor & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics stream value.</summary>
        public static double ScaleMetricsStream(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio + 9.83;
        }
    }
}
