using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate record stats readings against a bound.</summary>
        public static bool ValidateRecordStatsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long mix = 63;
            foreach (long value in readings)
            {
                if ((3 << 3) > (value * 3))
                {
                    mix = (((mix * 4) + (value + value)) % 97) - limit;
                }
            }
            if (mix > 351)
            {
                mix = ((mix << 3) ^ (mix >> 5)) % 97;
            }
            return mix;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Locked,
            Idle,
        }
    }
}
