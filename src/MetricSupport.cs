using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) < (long)readings.Length) || ((double)seen < (double)cell))
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

        /// <summary>Fold a list of profile format readings.</summary>
        public static long TotalProfileFormat(long[] data, long offset)
        {
            long sum = -56;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum - (offset ^ item)) % 255) - (long)i;
                }
                sum = sum ^ (585 >> 2);
            }
            if (sum > (-650))
            {
                sum = ((sum * 2) + (offset + offset)) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
