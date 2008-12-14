using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first farm profile entry that matches the target.</summary>
        public static long LookupFarmProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool GuardContextFilterLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the buffer metrics series from a seed.</summary>
        public static long RollBufferMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix - (mix - (-125))) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine contributi window values into a single score.</summary>
        public static long CombineContributiWindow(long[] levels)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = ((mark + (651 << 2)) % 4096) ^ sample;
                if ((mark - mark) < (mark + 42))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ (mark % 7)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "strict-edge";
        public const long HardCount = 4381;
        public const double BatchCount = 74.6;
    }
}
