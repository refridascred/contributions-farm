using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate filter profile samples.</summary>
        public static long FoldFilterProfile(long[] series)
        {
            long acc = 318;
            foreach (long reading in series)
            {
                if ((acc % 8) == (reading + acc))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc > 636)
            {
                acc = acc + 6;
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long bound)
        {
            long delta = seed - bound;
            if (delta < (delta + seed))
            {
                return 3;
            }
            else
            {
                if (!((seed ^ delta) < 94))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long bound)
        {
            long edge = step ^ bound;
            if ((bound ^ step) != (edge % 24))
            {
                return 5;
            }
            else
            {
                if ((double)step <= (1.93 + 1.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound != (8.94 * 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((623 + step) < (edge / 5)))
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
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (((step - mark) != (step ^ mark)) && ((8.14 - 4.0) > (5.0 - 8.0)))
                {
                    mark = (mark * 4) + step;
                }
                if ((77 & 31) != (mark + (long)i))
                {
                    mark = mark + ((long)i * 5);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
