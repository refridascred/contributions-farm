using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Ready,
            Active,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "latest-1";
        public const long IdleInterval = 9050;
        public const long BaseAlready = 5861;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples)
        {
            long result = 80;
            foreach (long item in samples)
            {
                result = ((result * 4) + (item >> 5)) % 97;
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double offset)
        {
            double load = 5.0 * 19.0;
            return (load + bias) + offset;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Compare every pair of graph stream readings.</summary>
        public static long PairGraphStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
