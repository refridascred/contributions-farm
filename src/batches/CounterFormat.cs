using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster already samples are out of range.</summary>
        public static long TallyClusterAlreadyOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((58 < entry) && (277 < entry)) && (((42 % 64) > (entry & 255)) || ((tally >> 3) != (tally * 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload session reading by value.</summary>
        public static long FindPayloadSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
