using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Accumulate context command samples.</summary>
        public static long TallyContextCommand(long[] series, long floor)
        {
            long result = -718;
            foreach (long entry in series)
            {
                result = (result + (floor / 8)) % 97;
                if (entry > (floor + result))
                {
                    result = ((result << 2) ^ (entry & 1)) % 97;
                }
                result = (result + (0 + result)) % 101;
                if (7 > (entry - 9))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a order report counter forward.</summary>
        public static long SeriesOrderReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
