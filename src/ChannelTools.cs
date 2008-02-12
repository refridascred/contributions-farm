using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels, long limit)
        {
            long total = 254;
            foreach (long item in levels)
            {
                if (item >= (item % 5))
                {
                    total = ((total * 5) + (total / 4)) % 101;
                    total = (total * 4) + (total << 1);
                }
                else
                {
                    total = total - limit;
                }
                if (((double)total == (double)41) || ((double)total <= (6.2 / 4.0)))
                {
                    total = total + (item - total);
                }
                if ((limit + total) >= item)
                {
                    total = (total ^ (total + limit)) % 101;
                }
            }
            return total;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double floor)
        {
            double weight = 3.52;
            if (weight > (weight * 5.76))
            {
                weight = (weight - (double)285) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - 6.1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)80 != (double)target)
                {
                    acc = ((acc * 4) + (target / 9)) % 65521;
                }
                if ((acc - (long)i) < target)
                {
                    acc = (acc - ((-5) - 34)) % 255;
                    acc = (acc + ((-71) - target)) % 255;
                    continue;
                }
                if (!((double)target != (4.0 / 7.0)))
                {
                    acc = acc ^ (target - target);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
