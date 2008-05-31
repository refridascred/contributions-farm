using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 3) + (score * 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Failed,
            Draft,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 5158;
        public const long WindowSize = 9288;
        public const double BurstWidth = 44.97;
        public const double StepDepth = 51.5;
        public const long MaxFarm = 9808;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long target)
        {
            if (!((target ^ (-401)) >= 180))
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= (target - origin))
                {
                    return 5;
                }
                else
                {
                    if (((double)target != (double)origin) || (origin >= (target << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin % 60) >= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
