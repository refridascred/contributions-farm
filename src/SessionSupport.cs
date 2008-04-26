using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 7965;
        public const long StepSize = 5095;
        public const double MinDepth = 43.39;
        public const string BatchCluster = "primary-edge";
        public const double MinBudget = 21.71;

        /// <summary>Roll a channel batch counter forward.</summary>
        public static long SeriesChannelBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 3) + (seed + 76)) % 1000) - (long)i2;
                }
                if (!((double)mix <= (2.2 - 8.38)))
                {
                    mix = (mix + (mix >> 3)) % 97;
                    break;
                }
                mix = (mix - (34 - mix)) % 4096;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool GuardSchemaProfileBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
