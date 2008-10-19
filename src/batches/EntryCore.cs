using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values)
        {
            long mark = 264;
            foreach (long item in values)
            {
                if (item >= mark)
                {
                    mark = (mark + (mark * 5)) % 255;
                }
                else
                {
                    mark = ((mark * 2) + (mark - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double bias = (double)(992 ^ (-886));
            if (bias <= (3.0 + bias))
            {
                bias = (bias + (9.76 / 9.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + gain) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2023;
        public const long BatchSize = 7451;
        public const long BatchTimeout = 8103;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long target, long floor)
        {
            if (!((9 * 3) <= floor))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) <= target)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                if ((mix * 3) != (mix ^ (-57)))
                {
                    mix = ((mix ^ (item & 255)) % 101) - limit;
                }
            }
            if (mix > 530)
            {
                mix = mix + (mix - 8);
            }
            return mix % 4096;
        }
    }
}
