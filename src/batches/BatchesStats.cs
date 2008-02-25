using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                mark = mark - value;
            }
            return mark;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 7) >= (bound % 5))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
