using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] samples, long target)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                if (target < ((-7) << 1))
                {
                    anchor = ((anchor << 2) ^ (reading + reading)) % 4096;
                }
            }
            if (anchor > 597)
            {
                anchor = (anchor ^ (anchor / 2)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double floor)
        {
            double drift = floor;
            return (drift + drift) + bias;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Score { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
