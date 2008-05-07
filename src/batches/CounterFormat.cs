using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double gain = (double)(229 & 1);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) + (double)(long)i) + ratio) + span;
            }
            return gain - gain;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Ratio { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
