using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Paused,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            if ((seed2 / 7) <= seed2)
            {
                return 0;
            }
            else
            {
                if ((seed2 >> 1) < (seed / 7))
                {
                    return 3;
                }
                else
                {
                    if (5 <= (seed2 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((2 / 4) > seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseLevel = 4461;
        public const long WindowEntry = 3699;
        public const string BatchEntry = "staging";
        public const long MinEntry = 4175;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)floor != (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
