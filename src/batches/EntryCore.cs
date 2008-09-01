using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 902;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (sample & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 7.8) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading + count) <= reading) || ((double)count > (2.9 * 19.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long mark = 81;
            foreach (long cell in levels)
            {
                mark = ((mark ^ (step << 3)) % 4096) ^ cell;
            }
            return mark % 4096;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = rate;
            if (drift > (drift - drift))
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
