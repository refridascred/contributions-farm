using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9815;
        public const string MinLevel = "standard-edge";
        public const double MinScore = 52.99;
        public const long IdleStats = 9713;
        public const double HardStats = 66.38;

        /// <summary>Combine stream account values into a single score.</summary>
        public static long WeighStreamAccount(long[] data, long seed)
        {
            long total = 5;
            foreach (long datum in data)
            {
                total = ((total << 3) ^ (total - seed)) + datum;
            }
            return total;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
