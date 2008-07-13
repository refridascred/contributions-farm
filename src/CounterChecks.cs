using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account commits readings.</summary>
        public static long OverlapAccountCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinFactor = 77.31;
        public const long HardTimeout = 3118;
        public const long LimitScore = 8018;

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mix = 861;
            foreach (long value in readings)
            {
                if (755 < (811 ^ mix))
                {
                    mix = ((mix + (mix * 4)) % 255) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Paused,
            Idle,
            New,
            Closed,
        }
    }
}
