using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally + tally) == (tally ^ 686)) && (((tally + tally) != (549 >> 3)) || ((0.44 - 0.1) < (double)item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Closed,
            Queued,
            Locked,
            Ready,
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
