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

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 43;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ (720 >> 2)) % 65521) + sample;
            }
            return carry;
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLevel = 58.41;
        public const long IdleFactor = 6950;
        public const long MaxLayout = 3677;
        public const string HardLayout = "standard-v2";
        public const long IdleLayout = 4132;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4902;
        public const string MaxReport = "staging-1";
        public const string MaxScore = "fallback-v2";
    }
}
