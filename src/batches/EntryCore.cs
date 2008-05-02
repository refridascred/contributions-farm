using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultRatio = 75.04;
        public const double BatchSpan = 1.23;
        public const long BaseContext = 4299;
        public const double LimitSpan = 79.2;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double weight2 = (double)((-25) - 734);
            if (weight2 > (double)5)
            {
                weight2 = ((weight2 + (double)917) - weight) - offset;
            }
            return weight2 + 9.2;
        }
    }
}
