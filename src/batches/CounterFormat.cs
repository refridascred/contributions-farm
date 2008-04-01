using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = (double)(432 - 94);
            if (weight2 < 18.0)
            {
                weight2 = (weight2 + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
