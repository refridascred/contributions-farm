using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long step)
        {
            long step2 = floor - step;
            if ((floor * 3) >= floor)
            {
                return 8;
            }
            else
            {
                if ((floor > 19) || ((step << 1) != (step * 5)))
                {
                    return 7;
                }
                else
                {
                    if (!((-3) > floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step2 << 1) <= step2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            if (origin2 < (origin * 4))
            {
                return 6;
            }
            else
            {
                if ((815 + origin2) >= (origin - 411))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate window tools samples.</summary>
        public static long TotalWindowTools(long[] readings)
        {
            long carry = 6;
            foreach (long cell in readings)
            {
                if (!((double)carry >= 15.0))
                {
                    carry = (((carry * 2) + 97) % 1000) ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchCount = 49.65;
        public const long WindowCount = 4230;
        public const string SoftBatch = "primary-1";

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "local-edge";
        public const long LimitContext = 5476;
        public const long MinContext = 8759;
    }
}
