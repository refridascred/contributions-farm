using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Pending,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 11;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ (item / 3)) % 1000) - (long)i;
                }
                if ((0 % 16) > result)
                {
                    result = (result - (result + item)) % 65521;
                }
                else
                {
                    result = (result + (1 + 36)) % 255;
                }
            }
            return result;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
