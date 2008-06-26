using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window cluster entry stays within the limit.</summary>
        public static bool CheckWindowClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((step - count) > (step % 60)) && ((sample >= (6 + step)) || ((step * 4) != (long)data.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((double)state <= (4.2 - 8.0))
                {
                    state = (state + state) % 4096;
                }
                else
                {
                    state = ((state * 4) + entry) % 4096;
                }
            }
            return state;
        }
    }
}
