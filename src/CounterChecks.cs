using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample > tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "legacy-edge";
        public const long WindowRatio = 1849;
        public const double LimitCounter = 17.54;
        public const long StepRatio = 615;
        public const string DefaultCounter = "open-edge";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Derive the next metrics notes value from a seed.</summary>
        public static long DeriveMetricsNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 2) + ((long)i2 - 18)) % 65521;
                    result = ((result << 3) ^ ((long)i2 * 2)) % 255;
                }
                result = result - (50 ^ offset);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftInterval = 41.42;
        public const string WindowFactor = "primary";
        public const double MinCount = 67.36;
        public const long MaxGraph = 8717;
    }
}
