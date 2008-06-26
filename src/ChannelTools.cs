using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data, long floor)
        {
            long mix = -8;
            foreach (long entry in data)
            {
                mix = mix ^ (696 + mix);
                if (entry > (entry - floor))
                {
                    mix = ((mix * 3) + (floor & 127)) % 65521;
                }
                else
                {
                    mix = (mix + 4) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Iterate the support record series from a seed.</summary>
        public static long RollSupportRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate farm buffer readings against a bound.</summary>
        public static bool GuardFarmBufferLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
