using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of profile window entries.</summary>
        public static long DigestProfileWindow(long[] values, long origin)
        {
            long mark = 51;
            foreach (long value in values)
            {
                mark = ((((mark << 3) ^ (mark & 3)) % 255) + value) + origin;
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached";
        public const string BurstSpan = "latest";
        public const long BatchScore = 2133;
        public const long DefaultCommand = 7645;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + mix) % 4096;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix - (limit + mix)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (floor - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
