using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate cache stats samples.</summary>
        public static long CombineCacheStats(long[] values, long origin)
        {
            long score = 6;
            foreach (long cell in values)
            {
                score = (((score - 51) % 1000) - cell) - origin;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches <= (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
