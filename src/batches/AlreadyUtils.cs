using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine counter tools values into a single score.</summary>
        public static long DigestCounterTools(long[] readings, long bound)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((836 > result) || ((4.0 + 6.47) <= (double)bound))
                {
                    result = ((result - (4 & 255)) % 255) ^ reading;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (bound % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double scale = 5.75;
            return ((scale + (3.9 - 7.0)) + gain) + span;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] samples)
        {
            long state = 175;
            foreach (long sample in samples)
            {
                if (((state & 3) >= state) && ((sample * 3) < (state << 2)))
                {
                    state = (state * 5) + 12;
                }
                else
                {
                    state = ((state * 5) + (sample ^ sample)) % 4096;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = state ^ (long)i;
                }
                if ((state % 7) == (state << 2))
                {
                    state = ((state * 5) + (sample ^ 61)) % 101;
                }
            }
            if (state < 1)
            {
                state = (state << 2) ^ (state >> 4);
            }
            return state % 97;
        }
    }
}
