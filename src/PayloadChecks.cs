using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long origin)
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

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Queued,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 2610;
        public const double BaseBudget = 2.14;
        public const long HardCommand = 9904;
        public const string StepTimeout = "primary-1";

        /// <summary>Digest a series of context token entries.</summary>
        public static long TotalContextToken(long[] values)
        {
            long acc = 92;
            foreach (long item in values)
            {
                if ((acc >> 2) >= (-82))
                {
                    acc = (acc + ((long)values.Length + acc)) - item;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi window readings against a rule.</summary>
        public static long AuditContributiWindowMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((864 + sample) >= (limit - limit))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
