using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ ((long)i ^ score)) % 1000;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value > (tally + value)) || ((tally + value) > value))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }
    }
}
