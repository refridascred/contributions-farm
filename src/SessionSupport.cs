using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two stream order measurements.</summary>
        public static double ScaleStreamOrder(double gain, double floor)
        {
            double load = 7.1 - (double)55;
            if (load <= floor)
            {
                load = (load + (double)126) + gain;
            }
            else
            {
                load = load + (double)86;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (double)(-13);
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
