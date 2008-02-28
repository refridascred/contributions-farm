using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (weight - 5.9)) + (double)(long)i;
            }
            return rate - (double)640;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long acc = 442;
            foreach (long datum in samples)
            {
                if ((double)origin > (10.0 * 6.61))
                {
                    acc = (acc + (-362)) - datum;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin + origin)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardScore = 82.62;
        public const long WindowScore = 9239;
        public const string HardFormat = "staging-v2";
        public const string RetryRatio = "legacy-1";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Pending,
            Closed,
            Failed,
            Draft,
        }
    }
}
