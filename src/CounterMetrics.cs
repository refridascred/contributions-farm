using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long step)
        {
            long lane = bound ^ step;
            if ((step + step) < step)
            {
                return 5;
            }
            else
            {
                if (bound >= (step + 42))
                {
                    return 1;
                }
                else
                {
                    if ((bound + step) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((56 + step) > (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double ratio, double floor)
        {
            double gain = ratio;
            if (gain <= (7.82 + gain))
            {
                gain = (gain + (13.0 / 8.0)) + floor;
            }
            return gain - ratio;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9654;
        public const long BaseFilter = 3473;
        public const string SoftWidth = "stable-1";
        public const double MaxFilter = 40.92;
        public const long LimitTimeout = 1384;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)22 < (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
