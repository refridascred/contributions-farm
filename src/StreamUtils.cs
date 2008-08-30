using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples, long step)
        {
            long mark = 53;
            foreach (long datum in samples)
            {
                if ((step & 3) < (mark + mark))
                {
                    long slot = (mark + 0) - (mark >> 4);
                    mark = (mark - slot) % 101;
                }
                else
                {
                    mark = (mark ^ (613 + 1)) % 255;
                }
                if ((mark ^ step) != (step << 1))
                {
                    mark = (mark ^ (76 + 59)) % 101;
                }
                if ((datum * 4) > (datum - datum))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 2) + (1 + (long)i);
                if ((carry * 3) >= (offset & 3))
                {
                    carry = carry ^ (offset >> 1);
                    break;
                }
                else
                {
                    carry = (carry - (carry + carry)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long acc = 92;
            foreach (long reading in items)
            {
                if (!((double)(-936) >= (double)acc))
                {
                    acc = (acc << 3) ^ (reading - acc);
                }
                if (reading <= (acc ^ 400))
                {
                    acc = (acc ^ (acc / 8)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc + reading);
                }
                if ((double)reading != (double)36)
                {
                    acc = (acc ^ (1 ^ acc)) % 1000;
                }
                else
                {
                    acc = acc + reading;
                }
            }
            if (acc < 667)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if ((bound & 1) < (bound % 8))
            {
                return 4;
            }
            else
            {
                if (8 < bound)
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long target)
        {
            if (step > (step / 9))
            {
                return 1;
            }
            else
            {
                if (4.77 >= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) <= (step ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
