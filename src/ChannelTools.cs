using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Stale,
            Active,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long CountContextSchemaOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4 / 2) > (count % 24))
                {
                    count = ((count + 2) - datum) + target;
                }
            }
            return count;
        }
    }
}
