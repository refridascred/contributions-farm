using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Locked,
            New,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4355;
        public const string RetryDepth = "stable-1";
        public const long DefaultFarm = 2324;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double bias = (double)(4 - 7);
            if (bias < (gain + 7.59))
            {
                bias = (bias - bias) - span;
            }
            return bias - bias;
        }
    }
}
