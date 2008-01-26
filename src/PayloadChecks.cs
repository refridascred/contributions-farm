using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((62 << 1) == (entry & 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long target)
        {
            if (((72 << 1) < target) || ((17.0 + 4.0) > (double)target))
            {
                return 7;
            }
            else
            {
                if (((offset + 98) == (7 ^ target)) || ((3.0 - 5.5) >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (((offset + target) < (offset % 10)) || ((target - 357) >= (offset + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Paused,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Audit githubfarm batch readings against a rule.</summary>
        public static long MeasureGithubfarmBatchOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches > (1.6 / 6.0))
                {
                    matches = ((matches + 3) - reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long floor, long offset)
        {
            if ((double)offset <= (3.39 - 9.5))
            {
                return 2;
            }
            else
            {
                if (((-846) >> 3) > (floor % 16))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 5) < (floor & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
