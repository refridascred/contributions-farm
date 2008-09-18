using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ item) % 4096;
                anchor = (anchor ^ (4 * 4)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double scale = 3.1;
            if (scale < 8.1)
            {
                scale = scale + bias;
            }
            return scale + offset;
        }
    }
}
