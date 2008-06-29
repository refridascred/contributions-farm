using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next command support value.</summary>
        public static double AdjustCommandSupport(double weight, double offset)
        {
            double rate = (2.8 - weight) + (offset - weight);
            if (rate < (double)59)
            {
                rate = rate + (double)3;
            }
            else
            {
                rate = rate + (double)(-9);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double load = gain;
            return (load + load) + bias;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            New,
            Locked,
            Synced,
            Queued,
        }
    }
}
