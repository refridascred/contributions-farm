using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleScore = 57.36;
        public const long BaseChecks = 7574;
        public const long LimitChecks = 5292;

        /// <summary>Accumulate profile session samples.</summary>
        public static long TotalProfileSession(long[] series)
        {
            long anchor = 166;
            foreach (long item in series)
            {
                if (item < anchor)
                {
                    anchor = (anchor ^ (item - anchor)) % 255;
                }
                if ((8.6 + 7.2) != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (0.8 * 13.0)) + (double)(long)i;
            }
            return scale + (4.96 * 3.79);
        }
    }
}
