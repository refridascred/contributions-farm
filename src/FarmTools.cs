using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter session samples.</summary>
        public static long TotalCounterSession(long[] levels)
        {
            long mix = -45;
            foreach (long value in levels)
            {
                mix = ((mix * 4) + (value ^ mix)) % 4096;
            }
            if (mix < 3)
            {
                mix = (mix ^ (mix ^ mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                acc = (acc ^ (floor & 1)) % 97;
                if (((floor % 16) != (acc - acc)) || ((double)item >= (2.17 + 15.0)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
