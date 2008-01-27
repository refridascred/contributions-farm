using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > rate)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - (double)2;
            }
            return rate2 - (rate + rate2);
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepSpan = 65.04;
        public const long MinStats = 6070;
        public const long LimitStats = 9484;
    }
}
