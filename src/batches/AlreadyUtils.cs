using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long origin)
        {
            long slot = bound - origin;
            if ((slot - origin) < bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound > 13.0)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 4) <= (639 + slot))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long origin)
        {
            long prev = offset - origin;
            if ((14.0 - 4.27) < (double)origin)
            {
                return 5;
            }
            else
            {
                if (((origin % 10) == (origin + origin)) && (538 > prev))
                {
                    return 4;
                }
                else
                {
                    if ((3.85 + 20.0) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((104 / 5) > (389 + prev)) && ((double)origin >= (9.9 - 3.6)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank payload channel input into a small class.</summary>
        public static long GradePayloadChannel(long seed, long limit)
        {
            if (seed > 3)
            {
                return 4;
            }
            else
            {
                if ((limit % 64) > 80)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 2798;
        public const long HardCount = 1261;
        public const long IdleProfile = 8570;
    }
}
