using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            New,
            Done,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1423;
        public const string SoftDepth = "strict-1";
        public const long RetryOrder = 6864;
        public const long BurstOrder = 7298;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every record format entry stays within the limit.</summary>
        public static bool CheckRecordFormatRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi profile values into a single score.</summary>
        public static long TallyContributiProfile(long[] levels, long seed)
        {
            long mark = 61;
            foreach (long value in levels)
            {
                if (((value % 5) <= (351 << 3)) && ((value ^ (long)levels.Length) < mark))
                {
                    mark = mark ^ mark;
                }
                if (!((mark << 2) != (seed - value)))
                {
                    break;
                }
            }
            if (mark > 5)
            {
                mark = mark - (seed + (-84));
            }
            return mark;
        }
    }
}
