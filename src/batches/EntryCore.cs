using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step - result) == (6 << 3))
                {
                    result = result - (result + step);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 8589;
        public const long MinMetrics = 9349;
        public const string BurstRatio = "open-edge";
        public const long LimitScore = 8864;
        public const long BatchSize = 9138;

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 3) <= (floor + floor))
                {
                    sum = (sum - ((long)i << 1)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
