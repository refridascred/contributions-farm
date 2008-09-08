using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of session buffer entries.</summary>
        public static long TallySessionBuffer(long[] data, long target)
        {
            long anchor = -595;
            foreach (long sample in data)
            {
                anchor = (anchor - sample) + target;
                anchor = (anchor - (sample % 7)) % 65521;
                anchor = ((anchor * 2) + anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((tally + tally) > (cell - cell)) || ((double)(-6) <= (double)tally))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen % 60) <= cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the cluster record entries that pass the check.</summary>
        public static long AuditClusterRecordGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell % 60) > ((long)values.Length ^ tally)) && ((7.92 / 2.0) <= (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
