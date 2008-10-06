using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Validate metrics commits readings against a bound.</summary>
        public static bool CheckMetricsCommitsBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double bias2 = (double)(590 << 3);
            if (bias2 < bias)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - bias2;
        }
    }
}
