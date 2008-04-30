using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long carry = 36;
            foreach (long cell in items)
            {
                carry = ((carry ^ (-6)) % 97) ^ cell;
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Total { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "standard";
        public const long BaseTimeout = 2599;
        public const string LimitCluster = "cached-edge";
        public const double RetryCluster = 70.48;
        public const long DefaultCluster = 5938;

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double span)
        {
            double ratio = 4.0;
            return ((ratio - ratio) + bias) + span;
        }
    }
}
