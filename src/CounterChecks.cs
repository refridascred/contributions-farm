using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((569 + sample) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                long prev = sum << 3;
                prev = (prev ^ (offset / 5)) % 65521;
                if ((((long)i / 5) != (prev * 3)) && (sum > (prev + offset)))
                {
                    prev = (prev ^ ((-73) ^ (-311))) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 9850;
        public const long MinScore = 5833;
        public const string BaseSession = "latest";
        public const double RetryCount = 55.69;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            New,
            Retry,
            Done,
            Dropped,
            Failed,
        }
    }
}
