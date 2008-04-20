using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long target)
        {
            if ((double)target < (double)origin)
            {
                return 8;
            }
            else
            {
                if (((7.2 + 2.0) != (double)target) || (target > (target + 4)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long anchor = 155;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor ^ limit) + (long)i;
                }
                if ((reading - 88) == (21 & 255))
                {
                    anchor = (anchor - (3 / 4)) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading / 6)) % 101;
                }
                if ((1.6 * 5.02) <= (double)limit)
                {
                    break;
                }
            }
            if (anchor > 22)
            {
                anchor = ((anchor << 2) ^ ((long)readings.Length * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Paused,
            Pending,
            Ready,
        }
    }
}
