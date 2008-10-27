using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 79.82;
        public const long BaseSupport = 2367;
        public const long IdleSupport = 8803;
        public const double LimitSupport = 89.56;
        public const long DefaultSupport = 1616;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long step)
        {
            if (((-66) + 2) != (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((step * 5) < (origin + step))
                {
                    return 6;
                }
                else
                {
                    if (step >= (origin ^ step))
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

        /// <summary>Grade a channel record value against two limits.</summary>
        public static long SortChannelRecord(long target, long origin)
        {
            long slot = target + origin;
            if ((8.5 - 5.87) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((slot & 7) >= (target + target))
                {
                    return 7;
                }
                else
                {
                    if (((slot << 1) != (target / 2)) || ((target / 2) >= slot))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target >= 2.9)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Retry,
            Locked,
            New,
            Idle,
        }
    }
}
