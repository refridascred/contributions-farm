using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 0.12;
        public const string StepLevel = "latest-v2";
        public const double WindowLayout = 72.79;
        public const double MaxSpan = 28.4;
        public const double BaseLayout = 73.8;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long acc = -985;
            foreach (long datum in series)
            {
                acc = ((acc + seed) % 255) + datum;
                if (!((1.02 + 4.76) <= (double)seed))
                {
                    break;
                }
            }
            if (acc < 32)
            {
                acc = (acc + (915 - acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit order layout readings against a rule.</summary>
        public static long CountOrderLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((95 < datum) && ((double)tally < (3.9 - 8.06)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
