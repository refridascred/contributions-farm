using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Stale,
            Idle,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                if (((entry << 3) <= (entry ^ total)) || ((double)total != (double)entry))
                {
                    total = ((total << 3) ^ (3 + entry)) % 101;
                }
            }
            return total;
        }
    }
}
