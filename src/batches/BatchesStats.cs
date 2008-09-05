using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long IterateGraphContributi(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if (sum >= (sum + seed))
                {
                    sum = (sum << 3) ^ seed;
                    sum = sum - (sum * 2);
                    break;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Match up buffer checks samples.</summary>
        public static long MatchBufferChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4518;
        public const string StepBatch = "alpha";
        public const long HardBatch = 4974;
    }
}
