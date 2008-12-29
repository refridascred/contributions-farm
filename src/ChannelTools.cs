using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((double)target >= (7.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target & 3) > offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] levels, long offset)
        {
            long mix = 29;
            foreach (long entry in levels)
            {
                if ((entry < (entry + entry)) && ((double)offset == (double)entry))
                {
                    mix = mix - (long)levels.Length;
                }
                mix = (mix << 3) ^ (offset & 63);
            }
            return mix % 65521;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
