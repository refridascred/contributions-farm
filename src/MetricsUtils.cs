using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue record readings against a rule.</summary>
        public static long TallyQueueRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count < (double)entry) || ((6.2 + 5.26) != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine stats token values into a single score.</summary>
        public static long DigestStatsToken(long[] data, long floor)
        {
            long mark = 0;
            foreach (long item in data)
            {
                mark = ((mark ^ (item << 3)) % 1000) - floor;
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ (57 - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value ^ tally) < (tally - step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
