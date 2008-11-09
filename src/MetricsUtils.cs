using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long limit)
        {
            long gap = origin + limit;
            if (((gap + gap) >= limit) && ((7 + origin) < 52))
            {
                return 2;
            }
            else
            {
                if ((4.0 - 7.7) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin >= (gap * 5)) && (50 < gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (20.0 < (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long step)
        {
            if (((step + step) == (bound * 5)) && ((step - step) > (bound ^ bound)))
            {
                return 8;
            }
            else
            {
                if (step > (95 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound >= (2.3 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
