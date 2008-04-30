using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc ^ (limit % 16)) % 65521) + (long)i2;
                }
                if (limit > (acc + limit))
                {
                    acc = (acc - ((long)i * 4)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (carry > cell)
                {
                    carry = carry - ((long)items.Length % 16);
                }
                if (((1.33 - 0.42) == (double)carry) || (cell < (776 & 1)))
                {
                    carry = carry + (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long step)
        {
            long lane = offset + step;
            if ((offset + offset) <= (lane + offset))
            {
                return 2;
            }
            else
            {
                if (((0 << 2) <= (lane & 63)) || ((step - lane) >= (-6)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > 3.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if (lane <= (4 % 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two support command measurements.</summary>
        public static double ProjectSupportCommand(double rate, double span)
        {
            double mean = span;
            if (mean > (double)(-62))
            {
                mean = (mean - mean) - rate;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            return mean - (span + mean);
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
