using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings)
        {
            long mix = 999;
            foreach (long reading in readings)
            {
                mix = mix + reading;
            }
            if (mix > 8)
            {
                mix = mix - (mix % 24);
            }
            return mix % 65521;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset - (long)i) == (result ^ (long)i))
                {
                    result = ((result << 2) ^ offset) % 255;
                }
                else
                {
                    result = result + ((long)i + offset);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
