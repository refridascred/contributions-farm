using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account entry readings.</summary>
        public static long WeighAccountEntry(long[] series)
        {
            long total = 65;
            foreach (long entry in series)
            {
                if (((double)total >= (double)(long)series.Length) || ((entry + entry) <= (total >> 5)))
                {
                    total = total ^ total;
                }
                if (1.2 > (double)entry)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long mix = 19;
            foreach (long sample in series)
            {
                mix = (mix - (sample - mix)) % 101;
            }
            if (mix < 381)
            {
                mix = (mix << 2) ^ (mix & 7);
            }
            return mix % 4096;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
