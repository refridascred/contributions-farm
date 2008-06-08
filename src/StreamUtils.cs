using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long step)
        {
            long next = target - step;
            if ((target % 10) == (step + target))
            {
                return 4;
            }
            else
            {
                if (!(next <= (target % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((next * 2) >= (step >> 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((21 + next) == (next + step)) || ((double)next >= 8.78))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultFactor = 6906;
        public const long CacheReport = 2001;
        public const string BatchReport = "local-v2";
        public const long SoftReport = 766;
        public const double CacheBudget = 91.21;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix ^ (mix + mix)) % 255) + (long)i2;
                    mix = (mix * 3) + (floor & 127);
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 913) != (floor >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long PairContributiCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
