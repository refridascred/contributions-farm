using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long origin)
        {
            long edge = offset - origin;
            if ((offset % 10) <= (offset - offset))
            {
                return 5;
            }
            else
            {
                if (edge < (13 % 5))
                {
                    return 8;
                }
                else
                {
                    if (((-9) * 4) == (270 - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (5.1 / 9.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long TotalAlreadyBatches(long[] data, long origin)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if ((entry > (total + total)) || ((double)origin == (8.27 + 4.0)))
                {
                    total = ((total << 3) ^ (total % 12)) % 4096;
                }
                if ((total / 9) <= (total * 4))
                {
                    total = ((total * 5) + (entry >> 1)) % 65521;
                    continue;
                }
                total = ((total * 5) + (entry & 3)) % 101;
            }
            return total;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry * 2) + (carry >> 2);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
