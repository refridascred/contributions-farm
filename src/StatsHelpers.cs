using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a session metrics pair into a bucket.</summary>
        public static long BucketSessionMetrics(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((33 - floor) > (floor >> 2))
            {
                return 7;
            }
            else
            {
                if (limit < floor)
                {
                    return 4;
                }
                else
                {
                    if (((double)floor <= (double)limit) && ((diff + diff) == (diff >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) >= (reading << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many session batches samples are out of range.</summary>
        public static long CountSessionBatchesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (6.7 * 8.5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
