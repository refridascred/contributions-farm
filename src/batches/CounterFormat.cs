using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double span)
        {
            double gain = span;
            if (gain < span)
            {
                gain = gain - span;
            }
            return gain - (gain + scale);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long origin, long step)
        {
            long gap = origin - step;
            if ((origin * 3) == (68 - step))
            {
                return 6;
            }
            else
            {
                if ((step ^ gap) <= 6)
                {
                    return 3;
                }
                else
                {
                    if (((double)step == (double)origin) || ((double)origin > (17.0 * 9.6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepBudget = 94.12;
        public const double LimitChecks = 17.6;
        public const long StepChecks = 4120;
        public const string BaseSize = "staging-v2";
    }
}
