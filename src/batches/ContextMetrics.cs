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

        /// <summary>Count the commits profile entries that pass the check.</summary>
        public static long TallyCommitsProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((57 >> 5) <= (tally % 60))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
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
