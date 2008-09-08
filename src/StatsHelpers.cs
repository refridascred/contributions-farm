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

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 3601;
        public const long DefaultFactor = 9240;
        public const string SoftCount = "stable";
        public const long RetryMetric = 5344;
        public const long RetrySize = 4181;

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long ClassifyReportFilter(long origin, long step)
        {
            if ((origin - step) < (53 & 1))
            {
                return 5;
            }
            else
            {
                if (((0.6 * 5.95) >= (double)origin) && (origin < (step + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin - 3) >= (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step * 5) != (step % 64))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
