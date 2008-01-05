using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two cluster githubfarm measurements.</summary>
        public static double SmoothClusterGithubfarm(double gain, double offset)
        {
            double drift = offset / 8.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (17.0 + drift)) + (double)(long)i) + gain;
            }
            return drift - (double)86;
        }

        /// <summary>Roll a queue batches counter forward.</summary>
        public static long IterateQueueBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample + count) >= (count - sample)) || ((6.34 + 9.29) <= (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
