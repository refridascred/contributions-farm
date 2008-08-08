using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 53.71;
        public const long MaxBudget = 8006;
        public const string MinMetric = "latest-v2";
        public const long CacheRatio = 4454;
        public const long StepLevel = 489;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long offset)
        {
            long slot = step - offset;
            if ((6.1 + 3.01) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset + step) <= (slot & 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (1.0 + 12.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((hits - step) <= (hits - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
