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

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 9155;
        public const string CacheLevel = "legacy-1";
        public const long CacheInterval = 3533;
        public const string BatchBudget = "primary-v2";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowSize = 8453;
        public const double BatchDepth = 31.07;
        public const long RetryCommand = 4446;
    }
}
