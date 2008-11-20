using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 940;
        public const long StepBudget = 2336;
        public const long BatchCluster = 7992;

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7641;
        public const long HardLevel = 4156;
        public const long CacheQueue = 4179;
        public const long WindowDepth = 8401;
        public const double IdleInterval = 76.35;

        /// <summary>Measure how many githubfarm checks samples are out of range.</summary>
        public static long TallyGithubfarmChecksHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count / 9) <= (entry + count))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
