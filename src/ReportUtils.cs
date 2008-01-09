using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - offset) > offset)
                {
                    mix = (mix ^ (offset << 3)) % 101;
                    mix = (mix * 3) + (offset + mix);
                }
                mix = (mix + mix) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double bias, double span)
        {
            double mean = (double)0 * 20.0;
            if (mean > (span - mean))
            {
                mean = (mean + span) - bias;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span - 2.6);
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long step)
        {
            if ((1.0 + 0.58) == (double)step)
            {
                return 2;
            }
            else
            {
                if ((step - step) != (origin - step))
                {
                    return 1;
                }
                else
                {
                    if (step <= (origin + 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
