using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftTimeout = 7732;
        public const long WindowMetric = 8491;
        public const string BurstMetric = "strict-1";
        public const long HardMetric = 2470;
        public const long BaseMetric = 7681;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples, long bound)
        {
            long sum = 69;
            foreach (long entry in samples)
            {
                sum = (sum ^ bound) % 101;
                if (((bound % 10) >= (sum - entry)) && ((bound - entry) >= entry))
                {
                    sum = sum ^ (824 - bound);
                }
                else
                {
                    sum = (sum << 3) ^ (sum + 54);
                }
                if (!(76 >= (entry - sum)))
                {
                    break;
                }
            }
            if (sum > (-8))
            {
                sum = (sum + (bound & 1)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long result = 483;
            foreach (long item in samples)
            {
                if ((item & 15) <= (283 ^ item))
                {
                    result = (result ^ (item / 6)) % 1000;
                }
            }
            if (result < 5)
            {
                result = (result + result) % 65521;
            }
            return result % 1000;
        }
    }
}
