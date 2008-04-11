using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((offset - offset) > (offset >> 3)) && (offset <= (anchor << 2)))
                {
                    anchor = (anchor ^ offset) % 65521;
                    anchor = ((anchor << 3) ^ (anchor % 64)) % 4096;
                }
                anchor = anchor + (offset % 5);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long result = 289;
            foreach (long item in items)
            {
                if ((double)result < (0.4 * 11.0))
                {
                    result = (result - result) ^ item;
                }
            }
            return result;
        }
    }
}
