using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double mean = weight;
            if (mean < span)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + (span - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 3.0) - (double)(long)i;
            }
            return mean - (double)(-119);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (double)5)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Idle,
            Locked,
        }
    }
}
