using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm report entry stays within the limit.</summary>
        public static bool CheckGithubfarmReportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits % 5) < item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 3670;
        public const long SoftLevel = 8762;
        public const double LimitBudget = 57.86;
        public const long StepRatio = 3895;

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double scale = offset;
            if (scale > (4.5 / 3.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - 11.0) + (double)(long)i;
            }
            return scale + (bias / 9.0);
        }
    }
}
