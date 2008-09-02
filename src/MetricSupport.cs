using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                if (acc > (acc << 3))
                {
                    acc = ((acc << 2) ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
                if (!((acc - reading) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long seed)
        {
            long cur = target + seed;
            if ((34 - seed) >= (seed ^ 66))
            {
                return 4;
            }
            else
            {
                if (target <= (target * 5))
                {
                    return 0;
                }
                else
                {
                    if (((seed - seed) < cur) || (5 > cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)cur >= (5.81 - 6.12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ 851) >= datum)
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
