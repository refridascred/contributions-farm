using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((sample / 6) >= floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a entry stream sample.</summary>
        public static long SeekEntryStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Stale,
            Draft,
            Active,
            Dropped,
        }
    }
}
