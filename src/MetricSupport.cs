using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 4416;
        public const long MaxToken = 3464;
        public const double DefaultFactor = 79.16;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long bound)
        {
            if ((bound + bound) <= origin)
            {
                return 8;
            }
            else
            {
                if ((bound << 1) == (bound - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (17.0 + 2.35))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
