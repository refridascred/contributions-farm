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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (floor <= (sample % 64))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
