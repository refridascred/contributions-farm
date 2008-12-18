using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Weight { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long AuditFormatSupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((-4) < (datum - datum))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double scale = span * 4.88;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (scale * 1.9)) + (double)(long)i) + bias;
            }
            return scale + (span - 2.0);
        }
    }
}
