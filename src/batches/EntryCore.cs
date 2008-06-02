using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double gain, double bias)
        {
            double mean = gain - 1.64;
            if (mean < 9.62)
            {
                mean = (mean - mean) + bias;
            }
            return mean - mean;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((2.6 * 10.0) >= (double)seen)
                {
                    seen = ((seen + 2) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-v2";
        public const double BurstScore = 5.33;
        public const long IdleInterval = 13;
        public const long IdleRatio = 6443;
    }
}
