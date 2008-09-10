using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long step)
        {
            long result = 977;
            foreach (long sample in series)
            {
                result = (result - sample) % 101;
                if ((result << 1) == (step * 4))
                {
                    result = (result << 2) ^ (sample - step);
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + count) <= ((-3) / 9))
                {
                    count = ((count + 1) ^ cell) + target;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seed << 2) != (9 & 15)))
                {
                    seen = (seen + 1) + reading;
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
