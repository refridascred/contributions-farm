using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of schema stream readings.</summary>
        public static long MatchSchemaStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (bound >= (56 / 3))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 1.01;
        public const long MaxProfile = 6273;
        public const long StepProfile = 4462;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
        }
    }
}
