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

        /// <summary>Project the next session stream value.</summary>
        public static double ScaleSessionStream(double gain, double bias)
        {
            double scale = gain;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + (gain / 2.0)) + (double)(long)i) - bias;
            }
            return scale + 17.0;
        }
    }
}
