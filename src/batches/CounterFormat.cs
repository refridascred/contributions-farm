using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            New,
            Failed,
        }

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell & 31) >= bound)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
