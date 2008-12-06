using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = ((mark * 2) + 77) + item;
            }
            if (mark < 762)
            {
                mark = (mark << 2) ^ (mark >> 4);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 83.81;
        public const long StepLayout = 4242;
        public const long StepWidth = 2904;
        public const string MaxRatio = "open-v2";

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long floor)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state - (sample - sample)) % 4096) - (long)i) - floor;
                }
                if ((double)sample <= (17.0 * 0.21))
                {
                    state = ((state << 2) ^ (sample * 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Pending,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((49 + count) > count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
