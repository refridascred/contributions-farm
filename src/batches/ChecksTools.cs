using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long sum = 4;
            foreach (long value in items)
            {
                sum = (sum - (value * 2)) % 97;
                if (value >= sum)
                {
                    sum = (sum - value) % 101;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks graph value against two limits.</summary>
        public static long SortChecksGraph(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((floor + floor) < (offset + floor))
            {
                return 3;
            }
            else
            {
                if (((offset / 2) == (diff - floor)) || (floor >= (71 % 12)))
                {
                    return 8;
                }
                else
                {
                    if ((diff * 4) < offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long state = 3;
            foreach (long sample in data)
            {
                state = ((((state << 3) ^ (75 * 4)) % 4096) ^ sample) + limit;
            }
            return state % 1000;
        }
    }
}
