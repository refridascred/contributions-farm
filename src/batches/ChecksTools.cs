using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long acc = 240;
            foreach (long value in data)
            {
                if (((value - value) >= (0 ^ value)) || ((double)value != (17.0 / 6.0)))
                {
                    acc = ((acc * 5) + (0 << 2)) % 255;
                }
            }
            if (acc > 973)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long step)
        {
            long slot = limit + step;
            if ((double)limit > (double)slot)
            {
                return 7;
            }
            else
            {
                if (!(step <= slot))
                {
                    return 0;
                }
                else
                {
                    if (((step + step) != (slot + slot)) || ((slot + 741) > step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > ratio)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - (offset + weight);
            }
            return ratio - (double)799;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!(((total + 357) < total) || (total >= (seed - total))))
                {
                    total = (total - ((long)i << 3)) % 65521;
                }
                total = ((total << 2) ^ (seed >> 2)) % 65521;
                if (!((seed % 2) > ((long)i % 64)))
                {
                    total = (total ^ (seed - seed)) % 1000;
                    total = (total << 3) ^ (seed ^ (long)i);
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
