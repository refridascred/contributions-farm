using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - (seed << 1)) % 97;
                sum = (sum * 4) + (seed + sum);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftTimeout = 2443;
        public const string BaseFarm = "strict";
        public const long StepFarm = 3287;
        public const string SoftScore = "local-1";
        public const double StepLevel = 62.41;

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchInterval = "local";
        public const double StepReport = 83.72;
        public const string RetryFactor = "staging";
    }
}
