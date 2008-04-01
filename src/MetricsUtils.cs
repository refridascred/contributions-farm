using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double weight = bias - bias;
            if (weight >= (double)69)
            {
                weight = (weight + bias) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (bias / 6.0)) - (double)(long)i;
            }
            return weight + (double)86;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftScore = "standard-edge";
        public const long HardWidth = 5919;
        public const string RetryContext = "stable";
        public const double MinLevel = 83.86;

        /// <summary>Match up support account samples.</summary>
        public static long PairSupportAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long anchor = 785;
            foreach (long item in values)
            {
                if (anchor >= (item / 8))
                {
                    anchor = (anchor + (item * 2)) % 97;
                    continue;
                }
                else
                {
                    anchor = (anchor * 3) + item;
                }
                anchor = (anchor << 3) ^ (item * 3);
                if ((15.0 - 1.1) == (double)anchor)
                {
                    anchor = anchor ^ (anchor / 6);
                }
                if ((anchor >= (53 / 4)) && (anchor > (anchor % 100)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
