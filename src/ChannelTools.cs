using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a checks editor sample.</summary>
        public static long SeekChecksEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
