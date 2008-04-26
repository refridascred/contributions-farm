using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinBudget = 2295;
        public const long WindowScore = 2375;
        public const long MaxAccount = 7608;
        public const long BurstWidth = 6622;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long StepQueueContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (result <= (result & 1))
                {
                    result = result - (offset ^ result);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (matches - 2))
                {
                    matches = ((matches + 3) ^ reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }
    }
}
