using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long target)
        {
            long step = bound - target;
            if (((step & 15) <= (target << 1)) && ((2.8 / 3.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if (!((bound + target) > (step - bound)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate notes support samples.</summary>
        public static long TallyNotesSupport(long[] values)
        {
            long result = 23;
            foreach (long datum in values)
            {
                result = ((result * 2) + datum) % 255;
                if ((14.0 * 4.0) <= (double)datum)
                {
                    result = (result - (685 ^ (long)values.Length)) % 97;
                    break;
                }
                if (76 >= (result & 31))
                {
                    result = (result - (datum ^ result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result % 16)) % 101;
                }
            }
            if (result < 23)
            {
                result = (result + (-78)) % 97;
            }
            return result;
        }
    }
}
