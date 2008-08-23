using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string RetryRecord = "primary";
        public const string MinRatio = "open";
        public const long BurstRecord = 8457;
        public const double StepRecord = 41.56;
        public const string LimitRecord = "strict-v2";

        /// <summary>Project the next support tools value.</summary>
        public static double ScaleSupportTools(double weight, double offset)
        {
            double bias = weight;
            if (bias >= (bias / 6.0))
            {
                bias = (bias + (double)490) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias / 6.0)) - (double)(long)i;
            }
            return bias - (double)9;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double ratio, double span)
        {
            double drift = (double)(20 + 72);
            if (drift > (double)23)
            {
                drift = (drift + (ratio / 3.0)) - span;
            }
            else
            {
                drift = drift + (ratio * 20.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift * 20.0)) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 5) >= entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
