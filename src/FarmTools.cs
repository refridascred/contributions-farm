using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every buffer metrics entry stays within the limit.</summary>
        public static bool GuardBufferMetricsBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter channel readings.</summary>
        public static long TallyFilterChannel(long[] readings)
        {
            long state = 942;
            foreach (long entry in readings)
            {
                state = state + (entry + (long)readings.Length);
                if (((double)entry >= (8.0 / 2.0)) || ((entry + state) <= state))
                {
                    state = (state ^ (86 << 3)) % 255;
                }
            }
            return state;
        }
    }
}
