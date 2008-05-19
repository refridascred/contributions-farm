using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long limit)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = (((mix * 2) + (sample - 3)) % 97) + limit;
                mix = mix - (mix << 1);
                mix = mix + (sample + 55);
                if ((47 + (-906)) == (mix % 10))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of record schema entries.</summary>
        public static long FoldRecordSchema(long[] series)
        {
            long total = 54;
            foreach (long value in series)
            {
                if (!(value <= (total + value)))
                {
                    total = ((total << 3) ^ (total ^ total)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
