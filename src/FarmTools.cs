using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long MeasureLayoutSchemaMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((9.9 + 6.59) < (double)tally))
                {
                    tally = ((tally + 2) + value) + origin;
                }
            }
            return tally;
        }

        /// <summary>Find the first filter window entry that matches the target.</summary>
        public static long LookupFilterWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi stream reading by value.</summary>
        public static long FindContributiStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
