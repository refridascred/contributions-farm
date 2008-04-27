using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long MeasurePayloadRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - 4) > (25 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long seed)
        {
            long offset = step + seed;
            if ((178 + offset) > (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)step < 1.0)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (seed >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed < (6.2 + 4.85)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (181 >> 2);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 2921;
        public const string DefaultContributi = "standard-v2";
        public const long MinContributi = 9377;
        public const long MaxLevel = 6587;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
