using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long floor, long step)
        {
            long prev = floor + step;
            if (((double)(-35) == (double)prev) && (prev > (floor - prev)))
            {
                return 6;
            }
            else
            {
                if ((645 + step) > (step << 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev - 97) <= 74) || ((step * 5) < (step ^ 23)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long TotalFormatLayout(long[] readings, long seed)
        {
            long mix = 58;
            foreach (long item in readings)
            {
                mix = mix ^ item;
                if (item >= (item + item))
                {
                    mix = mix + (item >> 4);
                    break;
                }
                if ((3.06 / 8.0) != (double)seed)
                {
                    mix = (mix + mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a batch route value against two limits.</summary>
        public static long GradeBatchRoute(long bound, long target)
        {
            long prev = bound ^ target;
            if ((5.0 - 2.7) == (double)bound)
            {
                return 5;
            }
            else
            {
                if ((prev + 121) <= prev)
                {
                    return 8;
                }
                else
                {
                    if ((3 + prev) > bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (double)(-67))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
