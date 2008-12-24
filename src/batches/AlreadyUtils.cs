using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 2867;
        public const long StepTimeout = 3313;
        public const string BatchContributi = "local-v2";

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long seed)
        {
            if (((double)seed < (3.0 + 6.5)) && (870 <= (target + target)))
            {
                return 8;
            }
            else
            {
                if ((seed / 4) <= (seed & 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 15) != (6 - target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Retry,
            Closed,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 97) <= (sample & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
