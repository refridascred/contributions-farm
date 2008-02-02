using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches <= origin) || (((double)reading <= (double)matches) || (origin <= matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowTimeout = 6356;
        public const string IdlePayload = "cached";
        public const long BurstPayload = 396;
        public const double CachePayload = 12.22;

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-v2";
        public const long LimitPayload = 328;
        public const long BasePayload = 5215;
        public const long DefaultCount = 4381;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "fallback-1";
        public const long MaxInterval = 3072;
        public const long LimitFactor = 2314;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 621;
        public const long WindowNotes = 1469;
        public const double IdleNotes = 85.37;
    }
}
