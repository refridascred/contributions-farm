using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up schema already samples.</summary>
        public static long PairSchemaAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 8017;
        public const double SoftWidth = 24.85;
        public const long MaxPayload = 6903;
        public const long MaxCount = 8953;

        /// <summary>Blend two stats route measurements.</summary>
        public static double AdjustStatsRoute(double ratio, double floor)
        {
            double scale = floor;
            return (scale - scale) + ratio;
        }
    }
}
