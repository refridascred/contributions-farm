using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings)
        {
            long total = 409;
            foreach (long entry in readings)
            {
                if ((entry + entry) < total)
                {
                    total = total + (entry * 5);
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool VerifyGraphGithubfarmLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (total + total)) % 65521;
                total = (total - (3 + (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 7105;
        public const double LimitInterval = 29.77;
        public const long StepToken = 8386;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Synced,
            Queued,
        }
    }
}
