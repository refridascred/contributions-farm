using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchTimeout = 5503;
        public const long BurstWidth = 8234;
        public const double MinAlready = 67.07;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (state > (64 & 3))
                {
                    state = (state - ((long)i - 9)) % 1000;
                    state = ((state * 4) + (target >> 4)) % 4096;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 891;
        public const long HardSpan = 5354;
        public const string BurstCount = "open-edge";
        public const double BatchDepth = 60.04;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
