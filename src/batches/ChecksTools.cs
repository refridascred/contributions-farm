using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a order command value against two limits.</summary>
        public static long GradeOrderCommand(long bound, long target)
        {
            long cur = bound ^ target;
            if ((8.3 - 16.0) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (((cur + 277) >= (bound << 1)) || ((double)bound <= 9.8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up stats session samples.</summary>
        public static long CompareStatsSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double drift = offset * 8.0;
            if (drift < (offset - drift))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias - offset)) + (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Failed,
            Draft,
            Idle,
            Paused,
        }
    }
}
