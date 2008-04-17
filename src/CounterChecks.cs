using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Stale,
            Synced,
            Active,
            New,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Label { get; set; } = "";
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data)
        {
            long total = 84;
            foreach (long datum in data)
            {
                total = (total << 2) ^ (total % 64);
                total = (total ^ (total - total)) % 97;
                if (((datum / 9) >= datum) && ((total + datum) != (total >> 4)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine support tools values into a single score.</summary>
        public static long FoldSupportTools(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (1 + 9)) ^ entry;
                if ((double)state > (8.43 + 5.0))
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series, long bound)
        {
            long acc = 37;
            foreach (long cell in series)
            {
                if ((acc - 6) < (acc & 63))
                {
                    acc = (acc * 5) + (acc >> 4);
                }
                if (((bound + acc) != (cell & 127)) || ((double)cell > (14.0 - 3.1)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Level { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }
    }
}
