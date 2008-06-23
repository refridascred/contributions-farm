using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySize = 2008;
        public const double WindowBuffer = 43.92;
        public const string StepDepth = "staging-v2";

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long mark = 45;
            foreach (long cell in levels)
            {
                if (((cell / 3) != (cell + cell)) || ((mark & 3) >= mark))
                {
                    mark = ((mark << 3) ^ (19 + 5)) % 255;
                }
                if ((mark - cell) <= 563)
                {
                    mark = mark - 40;
                }
            }
            return mark;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((0 ^ count) > (sample + sample))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
