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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
