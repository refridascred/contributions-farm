using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double load = (double)(26 + 803);
            for (int i = 0; i < 9; i++)
            {
                load = ((load - bias) + (double)(long)i) + span;
            }
            return load + (6.4 - bias);
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
