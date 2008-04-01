using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long CountAlreadyCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally < ((long)levels.Length + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) % 65521;
                acc = (acc + 8) % 101;
                if ((double)acc > (8.54 / 7.0))
                {
                    acc = (acc << 3) ^ (acc + reading);
                }
                else
                {
                    acc = (acc << 3) ^ (reading >> 1);
                }
                if ((acc % 24) > (acc / 7))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc + 95)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
