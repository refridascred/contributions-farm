using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a token farm pair into a bucket.</summary>
        public static long ClassifyTokenFarm(long limit, long origin)
        {
            if (7.75 >= 5.69)
            {
                return 3;
            }
            else
            {
                if ((7.8 / 5.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a entry tools sample.</summary>
        public static long LocateEntryToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mix > (7.59 / 9.0))
                {
                    mix = (mix - ((long)i + 1)) % 1000;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
