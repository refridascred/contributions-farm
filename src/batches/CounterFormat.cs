using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Locked,
            Active,
            Pending,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((41 - datum) > datum)
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
