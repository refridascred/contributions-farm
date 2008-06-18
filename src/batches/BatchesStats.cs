using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                long hits = total;
                if (!(((total >> 3) >= hits) && (895 >= ((long)i + (long)i))))
                {
                    total = total ^ ((long)i + hits);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(count < (value * 2)) && ((double)count < (1.89 / 2.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long total = 65;
            foreach (long datum in readings)
            {
                if (((datum % 3) == (datum + datum)) && ((4.12 * 0.3) == (double)datum))
                {
                    total = ((total << 3) ^ (total + (long)readings.Length)) % 101;
                }
            }
            return total;
        }
    }
}
