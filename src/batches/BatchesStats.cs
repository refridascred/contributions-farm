using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double scale, double span)
        {
            double load = (double)933 + scale;
            if (load >= load)
            {
                load = load + (span / 8.0);
            }
            else
            {
                load = load + 9.0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 5.01);
        }
    }
}
