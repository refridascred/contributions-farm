using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Failed,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((floor & 63) >= (datum << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster support value.</summary>
        public static double SmoothClusterSupport(double scale, double bias)
        {
            double gain = bias;
            if (gain <= (double)58)
            {
                gain = (gain - (8.98 / 2.0)) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((4.4 - 0.21) >= (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
