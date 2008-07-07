using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + (9.96 * 6.4)) + (double)(long)i) + scale;
            }
            return gain - gain;
        }

        /// <summary>Iterate the commits batches series from a seed.</summary>
        public static long IterateCommitsBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ ((long)i / 4)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
