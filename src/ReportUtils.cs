using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a queue stats figure with a bias.</summary>
        public static double AdjustQueueStats(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 9.0;
            return (bias2 + 3.0) + rate;
        }

        /// <summary>Check that every profile notes entry stays within the limit.</summary>
        public static bool GuardProfileNotesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 629;
        public const long BaseFactor = 6331;
        public const long MinWidth = 6873;
        public const double DefaultMetric = 54.84;
        public const string BatchMetric = "staging-v2";

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (weight * 17.0)) + (double)(long)i) + bias;
            }
            return weight - (weight + weight);
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Stale,
            Queued,
            Active,
        }
    }
}
