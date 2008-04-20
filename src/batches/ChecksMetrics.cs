using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 2) + (origin ^ origin)) ^ (long)i2;
                }
                mix = (mix ^ (origin ^ origin)) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 2) != (hits + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 2) ^ (749 >> 3)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double gain = 3.33;
            if (gain >= floor)
            {
                gain = (gain - 20.0) + ratio;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 2037;
        public const string BurstFactor = "primary";
        public const long StepScore = 4788;
        public const double BatchSpan = 54.83;
        public const long WindowStream = 5392;
    }
}
