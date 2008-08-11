using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics commits pair into a bucket.</summary>
        public static long SortMetricsCommits(long origin, long origin2)
        {
            long step = origin - origin2;
            if (origin2 > (origin2 >> 1))
            {
                return 1;
            }
            else
            {
                if ((origin2 & 127) == (step - 286))
                {
                    return 4;
                }
                else
                {
                    if (((origin >> 4) == (step + origin2)) || ((double)origin2 < (1.43 * 1.89)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)origin != (5.94 - 8.0)) || ((origin + origin2) < (origin2 + origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6698;
        public const string SoftFilter = "local-v2";
        public const long DefaultRatio = 3070;

        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double gain, double floor)
        {
            double bias = 2.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias + 7.0) + (double)(long)i) + gain) + floor;
            }
            return bias + (double)9;
        }
    }
}
