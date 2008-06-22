using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (value % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (((bound / 3) > bound) || ((floor - gap) > bound))
            {
                return 2;
            }
            else
            {
                if ((gap * 2) >= 125)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((hits + hits) <= item) || (item <= (hits % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 3742;
        public const long SoftCount = 1655;
        public const long StepGithubfarm = 832;
        public const string SoftGithubfarm = "cached-edge";
        public const long IdleDepth = 4007;
    }
}
