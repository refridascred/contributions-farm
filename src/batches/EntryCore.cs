using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "staging-edge";
        public const long MaxDepth = 2439;
        public const long IdleChannel = 6280;
        public const long SoftChannel = 437;
        public const long BaseChannel = 7266;

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

        /// <summary>Derive the next metrics contributi value from a seed.</summary>
        public static long IterateMetricsContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step << 1) <= step)
                {
                    mark = mark + step;
                }
                if ((double)mark != (8.0 - 11.0))
                {
                    mark = mark ^ (step / 8);
                    break;
                }
                else
                {
                    mark = (mark + (mark * 3)) % 255;
                }
                if (!(mark < ((-556) & 31)))
                {
                    mark = (mark + ((long)i + step)) % 65521;
                    mark = mark ^ ((long)i << 3);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
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
