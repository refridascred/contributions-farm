using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(entry < seen))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long FoldGithubfarmProfile(long[] items)
        {
            long carry = 89;
            foreach (long datum in items)
            {
                if ((double)datum == (10.0 / 6.0))
                {
                    carry = (carry - (datum + datum)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
