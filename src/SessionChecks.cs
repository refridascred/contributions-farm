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

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Closed,
            Queued,
            Done,
            Dropped,
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
