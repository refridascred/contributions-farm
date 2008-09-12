using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit profile schema readings against a rule.</summary>
        public static long AuditProfileSchemaGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed + count) <= 40)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((64 - cell) <= (offset % 97)) || ((cell + offset) <= ((long)levels.Length / 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((limit + cell) > 9)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
