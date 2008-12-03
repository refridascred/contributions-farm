using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= seed)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum - sum) % 4096;
                if ((double)sum < (3.74 + 2.0))
                {
                    sum = (sum + (offset ^ offset)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 101) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double mean = rate;
            if (mean > mean)
            {
                mean = mean + (offset * 16.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate / 3.0)) + (double)(long)i;
            }
            return mean + (rate + 9.0);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long origin, long origin2)
        {
            long prev = origin ^ origin2;
            if ((origin + origin) <= (prev - origin2))
            {
                return 5;
            }
            else
            {
                if (prev < (origin2 % 24))
                {
                    return 2;
                }
                else
                {
                    if ((prev * 5) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (242 >= (origin * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
