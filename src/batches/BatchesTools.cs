using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long sum = 895;
            foreach (long item in readings)
            {
                if ((484 - item) > (sum / 5))
                {
                    sum = ((sum << 2) ^ (origin << 2)) % 1000;
                }
                else
                {
                    sum = sum + sum;
                }
                if ((17.0 - 19.0) > (double)item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Locate a record farm reading by value.</summary>
        public static long LocateRecordFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long TallyMetricToolsMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((1.97 + 11.0) < (double)step)
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
