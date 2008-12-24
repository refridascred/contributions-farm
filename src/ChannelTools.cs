using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long target)
        {
            if ((seed > (seed + seed)) || (seed <= (seed + seed)))
            {
                return 7;
            }
            else
            {
                if (target <= (target * 4))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values, long limit)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = (((result << 3) ^ (sample & 7)) % 65521) - limit;
            }
            return result;
        }
    }
}
