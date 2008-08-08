using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double weight, double offset)
        {
            double load = 7.55 / 9.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + offset) - (double)(long)i) - weight;
            }
            return load - load;
        }
    }
}
