using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9889;
        public const string HardRecord = "alpha-1";
        public const long MinRecord = 2206;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally <= (7.0 / 8.0))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Draft,
            Done,
            Active,
        }
    }
}
