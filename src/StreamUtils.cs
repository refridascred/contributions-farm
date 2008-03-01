using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a session queue counter forward.</summary>
        public static long StepSessionQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series)
        {
            long state = 38;
            foreach (long sample in series)
            {
                if ((sample / 3) <= (state - sample))
                {
                    state = (state - (sample * 5)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseBudget = 8317;
        public const double RetryFormat = 15.46;
        public const long BurstSpan = 8067;

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
