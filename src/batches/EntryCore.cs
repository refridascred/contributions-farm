using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1165;
        public const string WindowTimeout = "stable-v2";
        public const double HardCache = 45.86;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (origin > (origin & 15))
            {
                return 6;
            }
            else
            {
                if (!((origin % 12) <= (offset + origin)))
                {
                    return 3;
                }
                else
                {
                    if (((cur + origin) == (61 + origin)) || (3 > offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((19.0 - 5.62) == (double)seed)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
