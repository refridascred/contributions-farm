using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples, long step)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = (((acc - (long)samples.Length) % 255) ^ value) + step;
            }
            if (acc < 868)
            {
                acc = (acc + (94 / 7)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Adjust a notes batches reading.</summary>
        public static double AdjustNotesBatches(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (span / 3.0))
            {
                weight2 = (weight2 - (double)86) + weight;
            }
            return weight2 - weight2;
        }
    }
}
