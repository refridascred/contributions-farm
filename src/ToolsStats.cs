using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((7.0 / 2.0) <= (double)(long)i)
                {
                    acc = ((acc * 3) + 458) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchSize = 69.03;
        public const double RetryStats = 90.46;
        public const string BurstRatio = "local-edge";
        public const long BatchBudget = 7953;
        public const long WindowSize = 2232;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings, long bound)
        {
            long carry = -494;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (carry - carry) ^ (long)i;
                }
                if ((carry + bound) > (reading ^ carry))
                {
                    carry = (carry + (reading + reading)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((18 - 79) > (775 - value))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
