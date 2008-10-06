using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 1902;
        public const double DefaultSpan = 11.99;
        public const double BaseInterval = 1.46;
        public const double StepGithubfarm = 11.04;

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double scale, double bias)
        {
            double load = (scale - 6.8) * 16.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias - 5.1)) + (double)(long)i;
            }
            return load - (load - scale);
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long ClassifyCommitsGraph(long floor, long bound)
        {
            long delta = floor + bound;
            if ((delta >> 4) == (floor >> 4))
            {
                return 8;
            }
            else
            {
                if (((double)floor > (1.62 - 7.6)) && ((double)delta != (14.0 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
