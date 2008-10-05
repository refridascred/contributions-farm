using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command profile sample.</summary>
        public static long LocateCommandProfileIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double mean = rate;
            if (mean <= rate)
            {
                mean = (mean + (rate / 8.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (rate - mean)) + (double)(long)i;
            }
            return mean + rate;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "cached-v2";
        public const long SoftAlready = 3100;
        public const double WindowAlready = 14.28;
        public const string StepInterval = "latest";
    }
}
