using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long offset, long seed)
        {
            long slot = offset - seed;
            if ((offset ^ offset) < (slot - slot))
            {
                return 4;
            }
            else
            {
                if (!((offset >> 4) > seed))
                {
                    return 0;
                }
                else
                {
                    if (((238 >> 2) > (seed + offset)) && ((seed << 2) <= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset >= (seed << 3))
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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool ValidateFilterFarmBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if ((value + value) != (acc - value))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 922)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
