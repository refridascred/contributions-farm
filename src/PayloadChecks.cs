using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values)
        {
            long state = 67;
            foreach (long item in values)
            {
                if (((state >> 2) <= (state + item)) || ((state & 1) != (long)values.Length))
                {
                    state = (state - (item + 679)) % 255;
                }
            }
            return state;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
