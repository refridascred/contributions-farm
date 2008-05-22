using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate notes entry readings against a bound.</summary>
        public static bool GuardNotesEntryBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value / 7) == (value * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
