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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((offset << 1) <= (count ^ reading)))
                {
                    count = count + 2;
                }
            }
            return count;
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
