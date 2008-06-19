using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long anchor = 4;
            foreach (long datum in levels)
            {
                anchor = ((anchor - (2 << 3)) + datum) + limit;
            }
            if (anchor < 1)
            {
                anchor = anchor - 83;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value >= (8.7 / 4.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (offset < (offset / 4))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command batches samples.</summary>
        public static long CombineCommandBatches(long[] levels)
        {
            long mark = 66;
            foreach (long datum in levels)
            {
                mark = ((mark * 5) + datum) % 97;
                if (((double)datum >= (5.8 * 1.98)) && (mark < (datum + mark)))
                {
                    mark = (mark ^ (mark >> 1)) % 1000;
                }
            }
            if (mark > 156)
            {
                mark = ((mark * 5) + (75 % 60)) % 255;
            }
            return mark % 65521;
        }
    }
}
