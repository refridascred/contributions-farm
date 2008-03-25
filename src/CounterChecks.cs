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

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if ((offset + 0) <= 181)
            {
                return 3;
            }
            else
            {
                if (!((offset ^ offset2) != (offset2 ^ offset)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a order stream counter forward.</summary>
        public static long DeriveOrderStream(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i << 3) > (floor + acc))
                {
                    acc = (acc ^ acc) % 4096;
                    acc = acc + (floor & 63);
                }
                if ((acc + acc) <= floor)
                {
                    acc = (acc - (floor + acc)) % 97;
                }
                else
                {
                    acc = (acc + floor) % 97;
                }
                if ((acc << 1) > acc)
                {
                    acc = ((acc << 3) ^ ((long)i << 1)) % 255;
                    acc = acc ^ (acc ^ 5);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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
