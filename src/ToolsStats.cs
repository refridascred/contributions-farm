using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxCount = 95.92;
        public const string MaxSpan = "alpha-v2";
        public const long SoftContributi = 8651;
        public const long LimitContributi = 5173;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((limit & 7) < 4) || (seed <= (edge % 97)))
            {
                return 5;
            }
            else
            {
                if ((seed + limit) > (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Idle,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length / 4) >= (sample ^ count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Retry,
            Failed,
        }
    }
}
