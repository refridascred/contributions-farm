using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double drift = rate;
            if (drift > (double)794)
            {
                drift = drift + (drift - span);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 1.2) + (double)(long)i;
            }
            return drift + 5.11;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < 18.0)
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
