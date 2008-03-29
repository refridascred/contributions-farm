using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long step, long seed)
        {
            if (!((seed - seed) > (step * 3)))
            {
                return 1;
            }
            else
            {
                if (((step - seed) > seed) || ((step & 3) > (step + 3)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((bound + value) >= bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
