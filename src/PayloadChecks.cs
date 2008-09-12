using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two stats batch measurements.</summary>
        public static double SmoothStatsBatch(double bias, double bias2)
        {
            double gain = bias;
            if (gain >= (bias2 / 8.0))
            {
                gain = gain - (double)7;
            }
            else
            {
                gain = gain - (double)58;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias2) - (double)(long)i;
            }
            return gain - (bias2 * 9.86);
        }

        /// <summary>Blend two metric already measurements.</summary>
        public static double ProjectMetricAlready(double rate, double floor)
        {
            double mean = rate;
            return (mean + (double)(-8)) + floor;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((86 - value) == (bound % 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((-55) * 2) >= bound)
                {
                    state = ((state * 5) + (bound + (long)i)) % 65521;
                }
                else
                {
                    state = (state * 5) + state;
                    state = (state + (606 % 100)) % 101;
                }
                state = (state << 3) ^ (bound - 95);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Idle,
            Closed,
            Synced,
            Pending,
            Paused,
        }
    }
}
