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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 0.85)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
