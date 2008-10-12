using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up stats route samples.</summary>
        public static long MatchStatsRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long floor)
        {
            long cur = bound ^ floor;
            if (bound >= (floor + cur))
            {
                return 8;
            }
            else
            {
                if ((bound <= (floor - 87)) || ((double)bound > (7.0 - 2.7)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= (cur / 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound & 15) < 874)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double scale = (double)((-407) & 31);
            if (scale < (double)818)
            {
                scale = (scale - 18.0) - gain;
            }
            else
            {
                scale = scale - (scale * 5.3);
            }
            return scale + floor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Idle,
            Dropped,
            Paused,
        }
    }
}
