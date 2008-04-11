using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 15;
        public const long RetryProfile = 4122;
        public const long HardProfile = 2910;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double weight, double offset)
        {
            double rate = (4.8 + weight) - weight;
            return (rate + rate) + offset;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
