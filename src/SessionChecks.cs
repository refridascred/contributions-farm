using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches + matches) < (sample * 2)) || ((197 ^ sample) <= (sample + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a token stats figure with a bias.</summary>
        public static double SmoothTokenStats(double weight, double span)
        {
            double mean = weight * 15.0;
            if (mean > 2.3)
            {
                mean = mean - (mean * 10.0);
            }
            else
            {
                mean = mean + (span / 7.0);
            }
            return mean + span;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
