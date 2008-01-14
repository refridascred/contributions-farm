using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account schema entries that pass the check.</summary>
        public static long CountAccountSchemaOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) < (bound << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data, long origin)
        {
            long anchor = 74;
            foreach (long datum in data)
            {
                anchor = (((anchor * 2) + datum) % 65521) - origin;
                if ((anchor % 24) > 2)
                {
                    anchor = (anchor - (datum + datum)) % 97;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
