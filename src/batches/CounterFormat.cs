using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Active,
            Queued,
            Locked,
        }
    }
}
