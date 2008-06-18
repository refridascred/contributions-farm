using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of schema payload readings.</summary>
        public static long PairSchemaPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = gain;
            return (mean + (double)2) + floor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6839;
        public const long LimitFormat = 4300;
        public const long DefaultFormat = 8228;
    }
}
