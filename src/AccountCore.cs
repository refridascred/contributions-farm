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

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels)
        {
            long mix = 9;
            foreach (long reading in levels)
            {
                mix = (mix + reading) % 97;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long offset, long seed)
        {
            if ((241 >> 3) >= (offset >> 4))
            {
                return 1;
            }
            else
            {
                if ((seed & 63) <= offset)
                {
                    return 0;
                }
                else
                {
                    if (((double)1 != (double)offset) || ((seed * 3) > (seed & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double gain = span;
            if (gain <= span)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + 5.89;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (3.2 - 2.6)) + (double)(long)i;
            }
            return gain + ratio;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "staging-1";
        public const double StepTimeout = 81.86;
        public const long SoftContributi = 8780;
    }
}
