using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long mix = 97;
            foreach (long item in samples)
            {
                if (((8.41 - 2.26) == (double)mix) || ((9 % 7) > (mix * 3)))
                {
                    mix = ((mix * 5) + (mix - item)) % 65521;
                }
            }
            if (mix > (-5))
            {
                mix = (mix + (bound >> 5)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Synced,
            Closed,
        }
    }
}
