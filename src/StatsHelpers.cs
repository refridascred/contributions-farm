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

        /// <summary>Classify a channel format pair into a bucket.</summary>
        public static long ClassifyChannelFormat(long limit, long target)
        {
            long prev = limit - target;
            if ((614 >= (limit & 7)) && ((double)prev >= (12.0 + 6.6)))
            {
                return 8;
            }
            else
            {
                if (prev > (limit * 5))
                {
                    return 6;
                }
                else
                {
                    if ((limit >= (prev - limit)) && ((target << 2) > (3 + 45)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
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
