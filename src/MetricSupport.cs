using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                if (acc > (acc << 3))
                {
                    acc = ((acc << 2) ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
                if (!((acc - reading) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 2110;
        public const long LimitQueue = 8818;
        public const long RetryQueue = 8920;
        public const string CacheQueue = "standard";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
