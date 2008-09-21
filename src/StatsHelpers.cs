using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if ((target2 + target) < (target2 / 9))
            {
                return 5;
            }
            else
            {
                if (40 <= target2)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long target)
        {
            long slot = floor ^ target;
            if (14.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((slot & 63) < (-50))
                {
                    return 6;
                }
                else
                {
                    if ((target & 3) > (slot - 67))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((slot + target) < (slot / 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 8164;
        public const long BurstSupport = 8656;
        public const long BatchRatio = 4964;
        public const long HardSupport = 3426;
    }
}
