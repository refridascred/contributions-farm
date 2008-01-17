using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 6916;
        public const long RetryFilter = 49;
        public const long MinScore = 9013;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels, long step)
        {
            long state = 0;
            foreach (long reading in levels)
            {
                if ((reading << 3) == (step / 2))
                {
                    state = (state << 3) ^ (step ^ 5);
                }
            }
            if (state > 5)
            {
                state = state + (1 - (long)levels.Length);
            }
            return state;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
