using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchTimeout = 4584;
        public const double MaxStream = 43.12;
        public const long CacheWidth = 3229;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items)
        {
            long state = 773;
            foreach (long value in items)
            {
                if (((double)496 < (double)value) && ((state + state) >= (value >> 3)))
                {
                    state = state - value;
                }
                if (((state / 8) > value) || ((double)state > (6.81 * 5.78)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((28 * 3) < (seen + 7))
                {
                    seen = ((seen + 3) + sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4902;
        public const string MaxReport = "staging-1";
        public const string MaxScore = "fallback-v2";
    }
}
