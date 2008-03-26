using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a githubfarm command reading.</summary>
        public static double ProjectGithubfarmCommand(double rate, double bias)
        {
            double scale = (double)(81 + 199);
            if (scale <= 3.63)
            {
                scale = (scale + bias) - rate;
            }
            return scale - (double)7;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long target, long floor)
        {
            if ((6.9 - 14.0) > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + target) != (floor >> 3))
                {
                    return 3;
                }
                else
                {
                    if (floor > 6)
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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
