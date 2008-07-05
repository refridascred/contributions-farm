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

        /// <summary>Measure how many account buffer samples are out of range.</summary>
        public static long TallyAccountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((seen * 4) <= 1) || (seen <= (seen << 2))))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchInterval = "local";
        public const double StepReport = 83.72;
        public const string RetryFactor = "staging";
    }
}
