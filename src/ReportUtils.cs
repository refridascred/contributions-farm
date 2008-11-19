using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((86 / 8) <= bound)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Active,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Count the batch context entries that pass the check.</summary>
        public static long MeasureBatchContextMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ limit) <= (limit & 255))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches < (matches ^ matches)) && (((3.0 - 10.0) < (double)cell) || ((cell * 4) != ((-8) * 2))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long sum = 96;
            foreach (long datum in items)
            {
                if (sum > (datum * 5))
                {
                    sum = (sum ^ (sum << 3)) % 1000;
                }
                if (!((sum & 31) <= sum))
                {
                    sum = ((sum << 3) ^ (719 / 6)) % 4096;
                }
                sum = (sum ^ (datum * 3)) % 4096;
            }
            if (sum > 26)
            {
                sum = ((sum << 2) ^ (38 % 7)) % 4096;
            }
            return sum;
        }
    }
}
