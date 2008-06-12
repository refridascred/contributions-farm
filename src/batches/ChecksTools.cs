using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] items)
        {
            long anchor = -64;
            foreach (long datum in items)
            {
                if (((anchor + 788) < (datum & 127)) && ((anchor & 3) > (datum >> 1)))
                {
                    anchor = (anchor << 3) ^ (anchor & 255);
                }
            }
            return anchor;
        }

        /// <summary>Classify a order account pair into a bucket.</summary>
        public static long ClassifyOrderAccount(long target, long target2)
        {
            if (!((target2 - 1) <= (target2 + target2)))
            {
                return 4;
            }
            else
            {
                if (((7.88 - 14.0) > (double)target) && ((target2 + 63) == ((-142) + target2)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
