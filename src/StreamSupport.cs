using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (5.5 / 7.0)) && ((reading / 7) < reading)) || ((double)count <= (6.1 * 3.98)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] items)
        {
            long mix = 8;
            foreach (long reading in items)
            {
                if ((0.42 / 8.0) >= (double)reading)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            if (mix > (-10))
            {
                mix = mix + ((-403) % 60);
            }
            return mix;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
