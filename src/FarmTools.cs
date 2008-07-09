using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Retry,
            New,
            Synced,
        }

        /// <summary>Project the next record entry value.</summary>
        public static double ScaleRecordEntry(double scale, double span)
        {
            double mean = (6.14 + span) - (span + span);
            if (mean > (0.19 / 2.0))
            {
                mean = (mean - (double)362) - scale;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - span;
        }
    }
}
