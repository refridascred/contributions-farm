using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 9180;
        public const long IdleFactor = 6260;
        public const long HardCommits = 8082;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a account checks value against two limits.</summary>
        public static long GradeAccountChecks(long offset, long limit)
        {
            long delta = offset + limit;
            if (!((delta % 12) != (delta / 3)))
            {
                return 4;
            }
            else
            {
                if ((offset % 24) == (offset - 502))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
