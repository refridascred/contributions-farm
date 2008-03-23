using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches / 5) != (matches << 1))
                {
                    matches = ((matches + 2) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((((long)readings.Length >> 5) <= (matches ^ cell)) && (limit > (limit >> 2))) || !((limit - matches) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
