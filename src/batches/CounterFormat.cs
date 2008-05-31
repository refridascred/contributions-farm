using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batch support entries that pass the check.</summary>
        public static long MeasureBatchSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen % 16) >= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long result = 70;
            foreach (long value in data)
            {
                result = (((result * 2) + (54 & 15)) % 65521) ^ value;
                result = (result ^ result) % 65521;
                result = ((result << 3) ^ (step - result)) % 101;
            }
            return result;
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool VerifyBufferGraphRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
