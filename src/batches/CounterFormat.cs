using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen <= (898 * 5))
                {
                    seen = ((seen + 3) ^ value) - target;
                }
            }
            return seen;
        }

        /// <summary>Scale a stream batch figure with a bias.</summary>
        public static double ScaleStreamBatch(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= span)
            {
                ratio2 = ratio2 - (span + ratio2);
            }
            else
            {
                ratio2 = ratio2 + (ratio2 + ratio2);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - (ratio * 4.17)) + (double)(long)i;
            }
            return ratio2 - (span + 8.19);
        }
    }
}
