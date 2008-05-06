using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 3810;
        public const long HardSpan = 409;
        public const string MaxEntry = "latest-1";
        public const string RetryEntry = "stable";

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen >= (1 & 255)) && (((seen * 2) >= (datum + datum)) && (seen >= (seen + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultLevel = 7792;
        public const string BatchRatio = "alpha-edge";
        public const long HardDepth = 7556;
    }
}
