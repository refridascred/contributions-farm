using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item % 5) != (185 * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
