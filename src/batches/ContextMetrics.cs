using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)(long)i >= (13.0 + 9.91)))
                {
                    mix = (mix * 5) + (mix >> 5);
                }
                else
                {
                    mix = (mix - (seed >> 1)) % 97;
                    mix = mix + mix;
                }
                mix = ((mix << 3) ^ (mix + 0)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 6656;
        public const long DefaultEntry = 1433;
        public const double StepEntry = 73.05;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 4341;
        public const long SoftChannel = 6636;
        public const double RetrySpan = 79.22;
        public const string WindowChannel = "legacy-edge";

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
