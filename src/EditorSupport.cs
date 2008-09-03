using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Mode { get; set; }
            public double Size { get; set; }
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

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long limit)
        {
            long result = 97;
            foreach (long sample in data)
            {
                if (sample <= (sample * 3))
                {
                    result = (((result * 4) + result) % 65521) - limit;
                    break;
                }
                result = (result ^ (result * 5)) % 4096;
                if ((2.0 / 3.0) > (double)sample)
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
