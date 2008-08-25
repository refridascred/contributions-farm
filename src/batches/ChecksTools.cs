using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double rate, double bias)
        {
            double load = (double)(6 / 5);
            if (load >= (rate * 7.13))
            {
                load = (load + 16.0) + bias;
            }
            else
            {
                load = load + load;
            }
            return load - (rate + rate);
        }

        /// <summary>Classify a cluster report pair into a bucket.</summary>
        public static long ClassifyClusterReport(long floor, long origin)
        {
            long lane = floor - origin;
            if ((floor / 7) < (lane ^ 30))
            {
                return 8;
            }
            else
            {
                if ((lane - floor) >= (840 - lane))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the layout metric entries that pass the check.</summary>
        public static long TallyLayoutMetricOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((step - seen) >= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
