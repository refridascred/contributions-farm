using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long TallyCounterGraphHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 2) != (tally ^ cell)) || (tally < (cell << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Failed,
            Paused,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (value >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload profile readings against a rule.</summary>
        public static long AuditPayloadProfileHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + target) <= (long)items.Length)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            if ((20.0 * 10.0) < (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin + offset) <= (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
