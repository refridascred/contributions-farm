using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (long)items.Length)
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

        /// <summary>Measure how many queue graph samples are out of range.</summary>
        public static long AuditQueueGraphOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((9.3 - 2.29) > (double)seen)
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 9) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally < (7.36 + 7.78))
                {
                    tally = ((tally + 2) + datum) - limit;
                }
            }
            return tally;
        }
    }
}
