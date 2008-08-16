using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally >= (2.7 - 2.04))
                {
                    tally = ((tally + 2) ^ reading) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if (((sample + offset) > offset) && ((double)offset > (0.88 + 11.0)))
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 514)
            {
                mark = (mark * 4) + (offset + mark);
            }
            return mark;
        }
    }
}
