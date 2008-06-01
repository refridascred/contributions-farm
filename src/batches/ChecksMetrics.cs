using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double span)
        {
            double mean = span;
            if (mean <= (double)72)
            {
                mean = mean + (mean + mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long bound)
        {
            if (bound > (bound + bound))
            {
                return 5;
            }
            else
            {
                if (((step + bound) <= (bound + bound)) && (step < (bound / 7)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell > (count + 92)) && ((count - cell) > cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + step) > reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels)
        {
            long result = 4;
            foreach (long sample in levels)
            {
                result = ((result + (result & 63)) % 65521) - sample;
            }
            return result;
        }
    }
}
