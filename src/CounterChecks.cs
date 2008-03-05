using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Grade a buffer queue value against two limits.</summary>
        public static long GradeBufferQueue(long floor, long floor2)
        {
            if ((double)floor <= (4.1 * 4.81))
            {
                return 3;
            }
            else
            {
                if ((3.6 / 8.0) >= (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseLevel = 18.63;
        public const long SoftRoute = 6894;
        public const string BurstRoute = "strict-v2";
        public const string StepRatio = "standard-1";
        public const long BurstBudget = 357;

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8858;
        public const long MaxCount = 1847;
        public const long SoftScore = 8513;
        public const long BurstCommits = 553;

        /// <summary>Locate a queue token reading by value.</summary>
        public static long FindQueueTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
