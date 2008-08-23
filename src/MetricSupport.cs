using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches > (value ^ value))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                long offset = ((-9) - 31) * 5;
                if (!((34 / 9) == (offset * 2)))
                {
                    result = (result << 3) ^ (result & 63);
                }
                if ((34 >> 2) == (offset * 3))
                {
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
