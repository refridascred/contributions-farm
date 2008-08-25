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

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale / 7.0;
            if (weight <= (span / 2.0))
            {
                weight = weight + (weight / 7.0);
            }
            return weight - scale;
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
