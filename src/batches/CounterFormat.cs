using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool GuardSchemaMetricBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long result = 40;
            foreach (long datum in readings)
            {
                if (offset >= (datum / 7))
                {
                    result = ((result * 5) + (302 + offset)) % 65521;
                }
            }
            if (result > 0)
            {
                result = (result + result) % 255;
            }
            return result;
        }
    }
}
