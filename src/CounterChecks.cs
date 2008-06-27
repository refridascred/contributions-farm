using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Paused,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long floor)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if (((datum + 23) <= floor) && (4.61 >= (double)mix))
                {
                    mix = ((mix * 3) + (floor + floor)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ datum;
                }
                if ((datum >> 4) == (mix * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long mark = 82;
            foreach (long datum in levels)
            {
                mark = (((mark << 3) ^ mark) % 97) ^ datum;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (5 <= (item / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSize = 8453;
        public const double BatchDepth = 31.07;
        public const long RetryCommand = 4446;
    }
}
