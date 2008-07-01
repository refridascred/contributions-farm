using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long TallyEditorFilterMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((8.3 + 2.34) == (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3284;
        public const long DefaultStream = 2144;
        public const long WindowSpan = 3080;
        public const long BurstStream = 2863;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchBudget = 8037;
        public const double LimitStats = 32.29;
        public const long IdleTimeout = 8970;
        public const double HardFactor = 82.02;
        public const double SoftBudget = 85.45;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
