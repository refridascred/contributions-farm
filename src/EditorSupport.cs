using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Idle,
            Active,
            Done,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < 4.31)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)91) - (double)(long)i;
            }
            return scale2 - (scale2 - floor);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultScore = 72.86;
        public const long SoftBudget = 6466;
        public const long IdleFactor = 8090;
        public const long SoftCount = 3864;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (7.5 + 6.17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Retry,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Audit graph window readings against a rule.</summary>
        public static long AuditGraphWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (269 < (sample << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
