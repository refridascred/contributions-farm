using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if (!!(41 < (acc + (-63))))
                {
                    acc = acc ^ acc;
                    acc = acc ^ (step ^ acc);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already route input into a small class.</summary>
        public static long GradeAlreadyRoute(long seed, long step)
        {
            long span = seed - step;
            if (!((double)span <= (5.0 + 20.0)))
            {
                return 0;
            }
            else
            {
                if (span > step)
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (3.89 + 15.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Pending,
            Active,
            Locked,
            Done,
        }
    }
}
