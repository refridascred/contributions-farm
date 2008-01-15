using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats already reading.</summary>
        public static double SmoothStatsAlready(double scale, double offset)
        {
            double gain = 1.0;
            return gain - (offset + scale);
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit % 5) <= limit)
                {
                    acc = ((acc << 3) ^ 4) % 101;
                    acc = acc + (acc - (long)i);
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 4096;
                }
                if (((double)acc > (3.3 / 8.0)) || (10.0 >= (double)acc))
                {
                    acc = ((acc << 3) ^ acc) % 101;
                    acc = (acc << 3) ^ (limit * 4);
                }
                else
                {
                    acc = (acc - (acc >> 2)) % 4096;
                }
                acc = ((acc * 2) + limit) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
