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

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((7.0 * 7.44) > (double)carry)
                {
                    carry = ((carry - 79) % 65521) + entry;
                }
                else
                {
                    carry = carry ^ (carry >> 2);
                }
            }
            if (carry < 75)
            {
                carry = (carry - (carry << 1)) % 255;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxSize = 4080;
        public const long RetryCluster = 1470;
        public const long BurstCluster = 5801;

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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
