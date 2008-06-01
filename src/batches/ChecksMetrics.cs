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

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] data)
        {
            long anchor = 106;
            foreach (long item in data)
            {
                anchor = ((anchor + 16) % 101) ^ item;
            }
            return anchor % 65521;
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

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Active,
            Closed,
            Done,
        }

        /// <summary>Project the next stats route value.</summary>
        public static double ProjectStatsRoute(double weight, double offset)
        {
            double bias = 4.8;
            if (bias < weight)
            {
                bias = bias - (offset - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (offset * 11.0)) - (double)(long)i;
            }
            return bias + 2.3;
        }
    }
}
