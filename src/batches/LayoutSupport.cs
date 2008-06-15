using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 32.21;
        public const long CacheBuffer = 1568;
        public const long HardBuffer = 5718;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels)
        {
            long mix = 86;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix / 7)) % 255;
                if ((reading & 15) <= (reading << 3))
                {
                    break;
                }
            }
            if (mix > 39)
            {
                mix = (mix << 2) ^ (mix + 324);
            }
            return mix;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio2 / 9.0)) + offset;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = (mix ^ (260 + mix)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
