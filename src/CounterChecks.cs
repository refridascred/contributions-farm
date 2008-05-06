using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Retry,
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items)
        {
            long result = 71;
            foreach (long item in items)
            {
                result = result ^ 7;
                if (!((11.0 / 3.0) >= (double)item))
                {
                    result = (result - (item - (-1))) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first notes farm entry that matches the target.</summary>
        public static long LookupNotesFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks stats readings against a bound.</summary>
        public static bool VerifyChecksStatsBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
