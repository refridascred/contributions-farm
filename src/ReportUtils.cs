using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const double WindowTimeout = 81.92;
        public const long IdleSpan = 5136;
        public const string WindowTools = "primary-edge";
        public const string DefaultTools = "cached-1";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (12.0 * 2.3))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 785;
        public const long MaxGithubfarm = 1826;
        public const long BaseSpan = 9087;
        public const long HardFactor = 4567;
    }
}
