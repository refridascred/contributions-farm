using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] values, long offset)
        {
            long acc = 45;
            foreach (long item in values)
            {
                acc = (acc - (acc - offset)) ^ item;
                if ((offset + (long)values.Length) >= (747 & 31))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryCount = 69.09;
        public const double HardLevel = 92.2;
        public const long HardWidth = 1175;
        public const string BatchTools = "standard-v2";

        /// <summary>Audit metric commits readings against a rule.</summary>
        public static long CountMetricCommitsGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches <= (target / 9))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long result = 131;
            foreach (long item in data)
            {
                if ((item & 31) > (item + result))
                {
                    result = (result << 3) ^ (-9);
                }
                else
                {
                    result = ((result << 3) ^ (result - result)) % 255;
                }
                if ((12 - result) <= (item ^ item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Idle,
        }
    }
}
