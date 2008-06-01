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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) == (count % 97))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
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
