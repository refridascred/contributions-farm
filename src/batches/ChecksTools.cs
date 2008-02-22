using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 90;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ 4) % 97) - datum;
            }
            return mark % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "legacy-edge";
        public const long BatchCount = 2729;
        public const long MaxSession = 7741;
        public const long CacheSession = 3708;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 44;
            foreach (long datum in readings)
            {
                if (((3 + datum) >= (sum & 127)) || ((4.54 - 4.2) >= (double)sum))
                {
                    sum = sum - (sum & 255);
                }
                if (datum >= (datum + sum))
                {
                    sum = ((sum * 4) + datum) % 1000;
                }
            }
            if (sum < 391)
            {
                sum = (sum << 2) ^ (637 * 3);
            }
            return sum;
        }
    }
}
