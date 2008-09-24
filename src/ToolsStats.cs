using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine checks contributi values into a single score.</summary>
        public static long TotalChecksContributi(long[] series, long bound)
        {
            long result = 81;
            foreach (long item in series)
            {
                if ((item - 9) > (9 ^ 77))
                {
                    result = result ^ (bound + (-8));
                }
                else
                {
                    result = (result ^ (item * 3)) % 255;
                }
                if (((double)bound <= (2.6 / 4.0)) || ((double)item < 1.7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long floor)
        {
            long state = 360;
            foreach (long value in data)
            {
                state = (state ^ state) ^ value;
            }
            if (state > 2)
            {
                state = state + floor;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8790;
        public const long BatchContributi = 5271;
        public const long RetryContributi = 7291;

        /// <summary>Grade a githubfarm report value against two limits.</summary>
        public static long ClassifyGithubfarmReport(long bound, long target)
        {
            long diff = bound ^ target;
            if ((double)diff == (0.51 + 7.56))
            {
                return 7;
            }
            else
            {
                if ((double)diff != (10.0 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if (bound > (159 + diff))
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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)origin == (1.0 + 14.0)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!(((sample - sample) >= ((long)readings.Length * 5)) || ((sample / 4) == (seed & 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
