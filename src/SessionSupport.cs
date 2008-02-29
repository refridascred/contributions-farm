using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] samples)
        {
            long score = 35;
            foreach (long reading in samples)
            {
                if ((double)reading > (1.3 / 2.0))
                {
                    score = (score << 2) ^ (reading * 5);
                    continue;
                }
                score = ((score << 2) ^ (score % 64)) % 1000;
            }
            return score;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double weight = bias2;
            if (weight < (double)(-9))
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight + (bias + weight);
            }
            return weight + bias2;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
