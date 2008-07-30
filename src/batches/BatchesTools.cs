using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double bias, double offset)
        {
            double rate = (double)633 / 6.0;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + bias) + (double)(long)i) + offset;
            }
            return rate + bias;
        }
    }
}
