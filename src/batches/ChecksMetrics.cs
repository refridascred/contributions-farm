using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long DeriveClusterChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((1 ^ entry) <= tally) && ((entry & 127) < (entry >> 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Done,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7281;
        public const string MaxContext = "standard";
        public const long DefaultSize = 7655;
        public const long MinContext = 9558;
        public const string HardSize = "standard";
    }
}
