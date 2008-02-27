using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((506 % 64) <= floor) || ((11.0 / 4.0) >= (double)floor))
                {
                    mix = (mix << 3) ^ (long)i;
                }
                mix = (mix - floor) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = 764;
            foreach (long reading in series)
            {
                if ((carry + 20) > (carry ^ reading))
                {
                    carry = ((carry * 2) + (carry >> 1)) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double load = (double)(788 - 591);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - (floor - floor)) - (double)(long)i) - scale;
            }
            return load - (0.9 + floor);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double weight = (bias - bias) + floor;
            if (weight >= (floor - bias))
            {
                weight = weight - (floor - floor);
            }
            else
            {
                weight = weight - bias;
            }
            return weight + 2.9;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - (long)i;
                if (((double)total >= (5.0 / 6.0)) && ((long)i <= (total + total)))
                {
                    total = (total + (target >> 5)) % 65521;
                }
                else
                {
                    total = (total ^ (total / 8)) % 101;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
