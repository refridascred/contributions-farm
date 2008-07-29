using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double load = gain;
            if (load >= (load + 8.0))
            {
                load = (load + (double)7) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (9.2 - 0.91);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading << 2) == (seen >> 3)) || ((double)reading <= (4.7 - 1.15)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long bound, long seed)
        {
            if ((3 - bound) < 36)
            {
                return 2;
            }
            else
            {
                if (((bound + 856) <= ((-57) % 10)) || ((seed + 786) <= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound < (4.22 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryLevel = "stable-v2";
        public const double MinWidth = 66.7;
        public const long MinSize = 445;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
