using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = rate;
            return weight + span;
        }

        /// <summary>Classify a context record pair into a bucket.</summary>
        public static long GradeContextRecord(long step, long target)
        {
            long next = step - target;
            if ((double)next > 18.0)
            {
                return 7;
            }
            else
            {
                if (target >= (967 - step))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 4.47;
        public const long DefaultAlready = 3588;
        public const long BurstBudget = 5062;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Weight { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Draft,
            Done,
            Locked,
            Closed,
        }
    }
}
