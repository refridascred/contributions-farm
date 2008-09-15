using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many batch context samples are out of range.</summary>
        public static long TallyBatchContextHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + hits) > (hits ^ target))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 3) ^ (mix - offset)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "primary";
        public const long MinToken = 1015;
        public const double StepToken = 80.87;
        public const string IdleSpan = "latest-v2";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double drift = gain;
            if (drift <= drift)
            {
                drift = (drift - (drift * 6.0)) + offset;
            }
            else
            {
                drift = drift + (gain / 3.0);
            }
            return drift + (double)64;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSize = 1348;
        public const string StepBatches = "latest-1";
        public const double MinBatches = 34.06;
        public const string BurstInterval = "open-1";
    }
}
