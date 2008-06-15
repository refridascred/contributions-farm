using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Check that every commits githubfarm entry stays within the limit.</summary>
        public static bool VerifyCommitsGithubfarmRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((2.2 / 7.0) == (double)(long)i)
                {
                    total = ((total * 2) + (bound / 6)) % 1000;
                    total = ((total << 2) ^ ((long)i << 3)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a commits report reading by value.</summary>
        public static long LocateCommitsReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
