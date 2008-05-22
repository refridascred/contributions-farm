using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 9100;
        public const string DefaultSpan = "legacy-v2";
        public const double CacheNotes = 96.79;
        public const long DefaultNotes = 5237;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step << 2) < (mark ^ step))
                {
                    mark = ((mark << 2) ^ (step + mark)) % 65521;
                }
                mark = (mark ^ (mark + (long)i)) % 255;
                if ((9.0 - 8.0) >= (double)mark)
                {
                    mark = mark + (step & 3);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long step)
        {
            long cur = offset + step;
            if ((double)step < (10.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if (!((step << 2) > (step - 7)))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) > (cur - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
