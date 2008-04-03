using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (487 > (item % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long step)
        {
            long bound = origin ^ step;
            if ((origin * 4) < 52)
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (9.0 / 2.0)) || (((-6) << 2) <= bound))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = ((anchor * 2) + (item / 4)) % 1000;
            }
            if (anchor < 42)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Adjust a graph report reading.</summary>
        public static double SmoothGraphReport(double rate, double bias)
        {
            double mean = (double)((-774) & 63);
            if (mean > (rate - rate))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean - (bias + mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long CountProfileWindowMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) > origin)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
