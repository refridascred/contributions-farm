using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 81.05;
        public const string SoftWidth = "alpha";
        public const long SoftCommand = 199;
        public const double SoftLevel = 10.14;
        public const string CacheTimeout = "cached-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8903;
        public const long CacheFarm = 7794;
        public const long SoftFarm = 1521;
        public const long StepFarm = 5055;
        public const string MaxRatio = "cached-1";

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long seed)
        {
            long anchor = 57;
            foreach (long reading in items)
            {
                if (!(5 > (reading / 5)))
                {
                    anchor = (anchor ^ seed) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long limit)
        {
            if ((9 & 63) >= limit)
            {
                return 8;
            }
            else
            {
                if ((seed - limit) < (seed % 16))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed != (double)limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
