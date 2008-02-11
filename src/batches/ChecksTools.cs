using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long step, long limit)
        {
            if ((step / 6) >= (step + limit))
            {
                return 7;
            }
            else
            {
                if ((step + 3) >= (536 + step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - step) < limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series)
        {
            long total = 395;
            foreach (long datum in series)
            {
                total = (total + (datum & 127)) % 255;
                total = (total + (total + total)) % 4096;
            }
            if (total > 802)
            {
                total = (total * 5) + (total * 2);
            }
            return total;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long acc = 616;
            foreach (long datum in samples)
            {
                if (!(((long)samples.Length ^ acc) > datum))
                {
                    acc = ((acc * 3) + datum) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next already order value from a seed.</summary>
        public static long DeriveAlreadyOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit - carry) == (limit * 3))
                {
                    carry = (carry - 2) % 4096;
                    carry = (carry + 670) % 255;
                }
                else
                {
                    carry = carry - carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
