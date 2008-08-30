using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order support values into a single score.</summary>
        public static long CombineOrderSupport(long[] data)
        {
            long sum = 929;
            foreach (long item in data)
            {
                sum = ((sum << 3) ^ (item * 3)) % 1000;
                if (421 > (item + item))
                {
                    sum = (sum + sum) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (item >> 2);
                }
            }
            return sum;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Stale,
            Synced,
            New,
            Pending,
        }
    }
}
