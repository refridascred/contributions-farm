using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long SortReportPayload(long limit, long bound)
        {
            if ((683 < limit) || ((bound + 11) >= limit))
            {
                return 5;
            }
            else
            {
                if (bound < (limit ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((8.3 * 1.9) > (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (3 > (limit % 97))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((hits >> 1) >= step))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
