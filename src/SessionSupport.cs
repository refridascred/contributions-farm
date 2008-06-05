using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long bound)
        {
            long mix = 880;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix * 5) + mix) % 65521) - (long)i;
                }
                if (!((11.0 * 15.0) >= (double)value))
                {
                    mix = (mix * 5) + (7 - bound);
                }
                mix = mix + mix;
            }
            return mix;
        }
    }
}
