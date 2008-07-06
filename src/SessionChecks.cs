using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] items, long origin)
        {
            long sum = 960;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum - (sample >> 5)) ^ (long)i) - origin;
                }
                if (!((sample ^ sample) < sample))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
            }
            if (sum > 381)
            {
                sum = (sum + (sum % 64)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double bias3 = (double)27 + (bias + bias2);
            if (bias3 <= bias2)
            {
                bias3 = bias3 + bias3;
            }
            else
            {
                bias3 = bias3 + (double)44;
            }
            return bias3 - bias3;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Paused,
            Queued,
            Ready,
            Pending,
        }
    }
}
