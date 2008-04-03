using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((bound ^ reading) < (reading * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel window values into a single score.</summary>
        public static long TallyChannelWindow(long[] levels)
        {
            long score = 35;
            foreach (long cell in levels)
            {
                if (cell <= (cell >> 5))
                {
                    score = (score ^ (34 & 1)) % 255;
                }
                else
                {
                    score = score - (6 / 9);
                }
            }
            return score % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Queued,
            Done,
            Stale,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
