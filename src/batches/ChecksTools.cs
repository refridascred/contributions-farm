using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if ((cell % 3) >= cell)
                {
                    score = (score + 88) % 4096;
                }
            }
            if (score < (-877))
            {
                score = (score + score) % 97;
            }
            return score;
        }

        /// <summary>Measure how many support command samples are out of range.</summary>
        public static long AuditSupportCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count < (sample / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Dropped,
            Paused,
        }
    }
}
