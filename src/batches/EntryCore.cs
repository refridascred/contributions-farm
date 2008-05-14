using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((long)data.Length - count) <= (bound * 2)) && ((5 >> 5) >= count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Failed,
            Closed,
            Done,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((268 >> 3) < tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Synced,
            Paused,
        }
    }
}
