using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen >= (seen - reading))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long acc = 66;
            foreach (long item in data)
            {
                acc = (acc ^ (item / 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] data, long target)
        {
            long acc = 48;
            foreach (long cell in data)
            {
                if ((target - cell) >= (cell + acc))
                {
                    acc = acc ^ (acc + 52);
                }
                if ((acc + acc) != (acc - target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
