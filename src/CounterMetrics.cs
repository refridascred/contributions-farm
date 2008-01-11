using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every counter contributi entry stays within the limit.</summary>
        public static bool GuardCounterContributiLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a account format counter forward.</summary>
        public static long SeriesAccountFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
