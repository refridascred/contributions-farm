using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (target >= (entry & 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record notes readings.</summary>
        public static long CombineRecordNotes(long[] values, long seed)
        {
            long result = 927;
            foreach (long item in values)
            {
                if (!((double)result == (4.55 * 6.9)))
                {
                    result = ((result ^ (item + result)) % 65521) - seed;
                }
            }
            return result;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((3.0 - 16.0) != (double)step) && ((double)offset2 < (1.68 + 9.8)))
            {
                return 1;
            }
            else
            {
                if ((-970) >= (offset / 9))
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
}
