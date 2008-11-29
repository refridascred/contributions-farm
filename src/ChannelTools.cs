using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound >= (3.96 + 6.0))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
