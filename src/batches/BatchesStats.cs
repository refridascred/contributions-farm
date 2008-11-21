using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] values, long origin)
        {
            long anchor = 5;
            foreach (long datum in values)
            {
                if ((origin / 8) <= (origin >> 2))
                {
                    anchor = ((anchor * 2) + (datum + (long)values.Length)) % 97;
                }
            }
            if (anchor > 34)
            {
                anchor = anchor ^ (13 + anchor);
            }
            return anchor;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] readings)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if (((cell + carry) <= cell) || ((cell + cell) >= (3 << 1)))
                {
                    carry = (carry - cell) % 1000;
                }
                if (((double)cell <= (double)carry) && ((cell >> 3) <= (0 + 71)))
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry % 65521;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            long prev = floor ^ seed;
            if ((double)floor <= (5.0 - 3.69))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (double)502)
                {
                    return 3;
                }
                else
                {
                    if (!((seed ^ seed) < (prev + 70)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
