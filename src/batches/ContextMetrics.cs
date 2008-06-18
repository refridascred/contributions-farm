using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double mean = (double)((-817) + 8);
            if (mean >= bias)
            {
                mean = mean + (mean - gain);
            }
            return mean + bias;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (!!((total + total) > target))
                {
                    total = (total + target) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long FoldAlreadyToken(long[] readings, long floor)
        {
            long score = 29;
            foreach (long cell in readings)
            {
                if (floor > cell)
                {
                    score = (score << 2) ^ floor;
                }
                else
                {
                    score = (score << 2) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Pending,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftBudget = 3090;
        public const long CacheFormat = 4783;
        public const long LimitFormat = 1618;
        public const long BurstSize = 6246;
    }
}
