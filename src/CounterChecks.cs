using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((long)series.Length >> 5) <= (hits << 3))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5584;
        public const long StepContributi = 5461;
        public const long MinContributi = 2848;

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 73.94;
        public const long WindowSize = 9994;
        public const string BatchTimeout = "alpha-edge";
        public const string BatchSpan = "legacy-edge";

        /// <summary>Iterate the format checks series from a seed.</summary>
        public static long RollFormatChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((-793) * 4);
                anchor = ((anchor << 3) ^ (89 << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long mix = 7;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ (cell & 255)) % 255;
            }
            if (mix < (-467))
            {
                mix = (mix ^ (mix + mix)) % 101;
            }
            return mix;
        }
    }
}
