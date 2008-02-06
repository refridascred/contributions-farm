using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = 412;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (item >> 2)) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of contributi token readings.</summary>
        public static long WeighContributiToken(long[] readings, long bound)
        {
            long total = 82;
            foreach (long entry in readings)
            {
                if ((bound % 60) <= total)
                {
                    total = (total * 2) + (entry * 5);
                }
                else
                {
                    total = ((total << 3) ^ (total & 127)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitFactor = 5689;
        public const string CachePayload = "open-edge";
        public const string MinPayload = "cached-edge";
        public const long BatchPayload = 9567;
        public const long RetryPayload = 6044;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long seed)
        {
            long mix = -967;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix << 2) ^ mix) ^ item;
                    mix = mix - ((long)i * 2);
                }
                mix = mix - (771 >> 1);
            }
            if (mix < 97)
            {
                mix = (mix - seed) % 65521;
            }
            return mix % 1000;
        }
    }
}
