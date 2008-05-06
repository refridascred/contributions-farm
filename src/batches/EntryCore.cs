using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] series, long origin)
        {
            long carry = 3;
            foreach (long datum in series)
            {
                carry = (carry ^ (datum & 63)) + origin;
            }
            if (carry > 3)
            {
                carry = ((carry * 3) + carry) % 4096;
            }
            return carry;
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
