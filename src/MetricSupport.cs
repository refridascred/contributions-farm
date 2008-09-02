using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                if (acc > (acc << 3))
                {
                    acc = ((acc << 2) ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
                if (!((acc - reading) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data, long offset)
        {
            long sum = 595;
            foreach (long cell in data)
            {
                if ((sum >= 976) || (56 >= (sum + 785)))
                {
                    sum = ((sum << 2) ^ (offset + cell)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry & 3) <= 2) || ((count - entry) < (floor + entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
