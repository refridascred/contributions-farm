using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit cache token readings against a rule.</summary>
        public static long TallyCacheTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell >= (9 - cell)) || ((floor <= (491 / 8)) && (cell < (290 + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of notes entry readings.</summary>
        public static long MatchNotesEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm cache readings against a bound.</summary>
        public static bool GuardGithubfarmCacheBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value & 15) <= (110 - value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Done,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
