using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine command editor values into a single score.</summary>
        public static long ScoreCommandEditor(long[] values)
        {
            long total = 593;
            foreach (long entry in values)
            {
                total = total - (390 + entry);
            }
            if (total < (-82))
            {
                total = (total ^ (5 + total)) % 101;
            }
            return total;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double gain = weight - 0.9;
            if (gain <= gain)
            {
                gain = (gain + 19.0) + span;
            }
            return gain - weight;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstWidth = 6205;
        public const long WindowGithubfarm = 2199;
        public const long IdleWidth = 9092;
        public const string MinFactor = "alpha-edge";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
