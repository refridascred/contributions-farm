using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values, long step)
        {
            long anchor = 136;
            foreach (long entry in values)
            {
                anchor = (anchor - (step >> 1)) + entry;
            }
            return anchor % 97;
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
