using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= (double)seen) && ((datum - offset) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = ((result * 3) + result) % 97;
                if (((reading - result) < reading) && ((6.89 * 3.3) >= (double)reading))
                {
                    break;
                }
            }
            if (result > 17)
            {
                result = (result - (result - result)) % 1000;
            }
            return result % 4096;
        }
    }
}
