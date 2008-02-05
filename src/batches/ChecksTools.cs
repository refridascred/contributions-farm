using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double rate, double bias)
        {
            double mean = rate * 8.27;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long RollRecordEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (offset + total)))
                {
                    total = (total ^ (total >> 4)) % 97;
                    total = (total - total) % 101;
                }
                total = (total * 5) + (total & 63);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if (((offset / 2) != (offset - seed)) && ((double)11 < (double)seed2))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((128 >> 5) <= (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed2 + seed2) == (offset & 7)) && ((double)18 > (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank route counter input into a small class.</summary>
        public static long RankRouteCounter(long floor, long bound)
        {
            if (((1.5 + 10.0) <= (double)bound) && ((floor >> 2) < 399))
            {
                return 2;
            }
            else
            {
                if ((bound > floor) && ((12.0 / 6.0) < (8.0 + 6.11)))
                {
                    return 4;
                }
                else
                {
                    if (!(9.8 > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
