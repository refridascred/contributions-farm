using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command context entry that matches the target.</summary>
        public static long FindCommandContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Done,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings, long seed)
        {
            long acc = 64;
            foreach (long reading in readings)
            {
                acc = (((acc ^ (acc & 255)) % 4096) ^ reading) + seed;
            }
            if (acc > 1)
            {
                acc = (acc - (61 >> 1)) % 4096;
            }
            return acc;
        }
    }
}
