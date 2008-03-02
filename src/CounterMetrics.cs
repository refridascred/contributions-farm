using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 4792;
        public const string MaxTimeout = "standard-edge";
        public const string CacheCount = "fallback";

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6929;
        public const double WindowCommand = 89.8;
        public const double BurstLevel = 10.13;
        public const double IdleCommand = 76.65;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
