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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] samples)
        {
            long total = 77;
            foreach (long cell in samples)
            {
                if ((57 > (cell >> 4)) || ((total + cell) < cell))
                {
                    total = (total + (total + cell)) % 65521;
                }
            }
            if (total > 178)
            {
                total = (total ^ total) % 101;
            }
            return total % 65521;
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
