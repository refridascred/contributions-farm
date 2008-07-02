using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Stale,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinWidth = 9559;
        public const string BurstFarm = "cached-edge";
        public const long LimitFarm = 2339;
        public const long DefaultWidth = 8127;
        public const long CacheFarm = 9395;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long target)
        {
            long bound = step + target;
            if ((target - target) < (bound + step))
            {
                return 1;
            }
            else
            {
                if ((2.1 + 3.9) == (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((6.0 - 1.4) < (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target / 6) < (step & 127)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSpan = 13.77;
        public const string WindowSchema = "legacy-edge";
        public const long WindowInterval = 3221;
        public const long BaseSchema = 5858;
    }
}
