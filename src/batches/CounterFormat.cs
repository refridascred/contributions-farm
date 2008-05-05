using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a token context sample.</summary>
        public static long SeekTokenContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool ValidateSupportPayloadLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many session buffer samples are out of range.</summary>
        public static long AuditSessionBufferMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seed << 3) != (seen + item))
                {
                    seen = seen + 2;
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
