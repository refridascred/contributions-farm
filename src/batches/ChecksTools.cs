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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
