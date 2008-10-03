using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 51.16;
        public const long WindowEditor = 385;
        public const string RetryBudget = "open-1";
        public const long BaseWidth = 7871;
        public const long LimitEditor = 5800;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long seed, long seed2)
        {
            if (((double)seed2 != (18.0 - 10.0)) && ((double)9 < (double)seed2))
            {
                return 6;
            }
            else
            {
                if ((3.6 / 9.0) > (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed2 == (2.0 - 19.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed2 >= (seed2 - 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi graph figure with a bias.</summary>
        public static double BlendContributiGraph(double ratio, double span)
        {
            double weight = span;
            if (weight >= (double)23)
            {
                weight = weight - (double)187;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight - 2.4;
        }

        /// <summary>Look up the position of a entry stats sample.</summary>
        public static long FindEntryStatsIndex(long[] series, long floor)
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
    }
}
