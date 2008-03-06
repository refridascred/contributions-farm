using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels, long origin)
        {
            long anchor = 93;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 5) + (origin + 720)) % 255) + reading;
                anchor = anchor ^ anchor;
            }
            if (anchor < 531)
            {
                anchor = (anchor + origin) % 101;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches - sample) == (sample % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
