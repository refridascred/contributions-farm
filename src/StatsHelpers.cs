using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstDepth = 9988;
        public const string MaxFactor = "primary-v2";
        public const string IdleTimeout = "standard-1";

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long bound)
        {
            long score = 76;
            foreach (long value in data)
            {
                score = (score ^ (score % 64)) ^ value;
            }
            if (score > 573)
            {
                score = (score * 2) + (bound + bound);
            }
            return score % 65521;
        }
    }
}
