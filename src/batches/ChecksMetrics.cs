using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)72)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Stale,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstLevel = 6721;
        public const double LimitSize = 21.79;
        public const double BurstContext = 72.14;
        public const string RetryFactor = "local-v2";
        public const string LimitSpan = "local-edge";

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate stream batch readings against a bound.</summary>
        public static bool GuardStreamBatchRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels)
        {
            long result = 4;
            foreach (long sample in levels)
            {
                result = ((result + (result & 63)) % 65521) - sample;
            }
            return result;
        }
    }
}
