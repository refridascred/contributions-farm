using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 699;
        public const double StepNotes = 24.6;
        public const double DefaultNotes = 65.69;
        public const long MaxNotes = 4294;
        public const double CacheNotes = 10.18;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
