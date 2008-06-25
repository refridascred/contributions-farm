using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the metric support entries that pass the check.</summary>
        public static long MeasureMetricSupportMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + count) <= 758)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double bias = (weight + offset) - offset;
            if (bias >= (offset / 5.0))
            {
                bias = bias - (weight - weight);
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (bias + weight)) - (double)(long)i;
            }
            return bias - (double)1;
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool ValidateSchemaAlreadyLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a contributi support reading by value.</summary>
        public static long LocateContributiSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
