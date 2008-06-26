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

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long step)
        {
            if (24 < (step >> 2))
            {
                return 0;
            }
            else
            {
                if ((400 + bound) > (7 + (-81)))
                {
                    return 3;
                }
                else
                {
                    if (923 <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
