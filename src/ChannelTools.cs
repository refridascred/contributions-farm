using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order graph entry stays within the limit.</summary>
        public static bool GuardOrderGraphLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
