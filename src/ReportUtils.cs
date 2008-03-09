using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a format tools counter forward.</summary>
        public static long SeriesFormatTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) < (0 * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 606;
        public const string IdleWidth = "primary-edge";
        public const long DefaultLevel = 9822;
        public const long IdleDepth = 6199;
        public const double BatchCount = 67.12;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Ready,
            New,
        }
    }
}
