using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftSize = 34.04;
        public const string DefaultNotes = "stable-v2";
        public const long BatchNotes = 3386;
        public const long HardNotes = 9937;

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "open-edge";
        public const long BurstCounter = 4447;
        public const string BaseRatio = "fallback";
        public const long IdleDepth = 537;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long anchor = 436;
            foreach (long cell in items)
            {
                if ((cell + (long)items.Length) <= anchor)
                {
                    anchor = (anchor - (anchor / 9)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Audit session window readings against a rule.</summary>
        public static long MeasureSessionWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!!((-835) <= count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
