using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                if ((entry / 3) > (entry - 793))
                {
                    mix = (mix + 532) % 65521;
                }
                else
                {
                    mix = (mix + ((long)items.Length - 385)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Paused,
            Ready,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long result = 693;
            foreach (long item in samples)
            {
                if (((result ^ result) >= item) && ((9.74 * 6.0) <= (double)item))
                {
                    result = (result + 8) % 65521;
                }
            }
            if (result > 5)
            {
                result = (result ^ (result / 4)) % 101;
            }
            return result;
        }
    }
}
