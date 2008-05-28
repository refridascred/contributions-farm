using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ (mix - 2)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long SortContributiWindow(long offset, long seed)
        {
            if ((offset <= 764) || ((seed & 31) < (offset - offset)))
            {
                return 6;
            }
            else
            {
                if ((offset >= (469 + offset)) && ((3.0 * 1.87) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed <= ((-358) << 3)) || ((offset ^ offset) < 0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
