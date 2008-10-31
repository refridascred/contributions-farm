using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long step)
        {
            long state = 29;
            foreach (long item in data)
            {
                if ((36 >> 1) < (step << 1))
                {
                    state = ((state - step) % 1000) - item;
                }
            }
            if (state > 145)
            {
                state = (state ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (844 + 0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
