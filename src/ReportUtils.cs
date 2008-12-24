using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((2.38 / 7.0) >= (double)bound)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank batches support input into a small class.</summary>
        public static long BucketBatchesSupport(long floor, long bound)
        {
            if ((floor << 2) <= (bound ^ bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (3.13 * 0.9))
                {
                    return 5;
                }
                else
                {
                    if ((bound - floor) == (floor + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Dropped,
            Stale,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((double)value < (14.0 + 7.93)) || (tally < (value + 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
