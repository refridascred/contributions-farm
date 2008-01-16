using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long result = 24;
            foreach (long value in items)
            {
                result = result ^ (value / 9);
                if ((value + (-420)) <= (result << 2))
                {
                    result = ((result << 2) ^ (464 + 278)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen <= (9.78 - 9.51)) || (((18.0 / 3.0) >= (double)offset) || (6.0 > (double)seen)))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + load;
            }
            return load + 0.7;
        }
    }
}
