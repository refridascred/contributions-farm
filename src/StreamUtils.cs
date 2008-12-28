using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double rate = 9.1;
            if (rate <= (rate / 6.0))
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix - ((long)i & 255)) % 255;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two batches account measurements.</summary>
        public static double ProjectBatchesAccount(double gain, double span)
        {
            double drift = (5.57 * 8.5) - (gain + 3.73);
            if (drift < 0.98)
            {
                drift = drift + (16.0 * 17.0);
            }
            else
            {
                drift = drift + (6.56 * 12.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (span - drift)) - (double)(long)i;
            }
            return drift - (9.0 / 8.0);
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Active,
            Stale,
            Dropped,
        }
    }
}
