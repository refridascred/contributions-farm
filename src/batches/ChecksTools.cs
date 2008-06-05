using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine support counter values into a single score.</summary>
        public static long CombineSupportCounter(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if (mix < (long)levels.Length)
                {
                    mix = ((mix << 3) ^ (item + item)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 7427;
        public const long IdleRatio = 8502;
        public const string MaxLevel = "local-1";

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) == (reading >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
