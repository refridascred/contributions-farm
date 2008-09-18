using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate queue commits samples.</summary>
        public static long TallyQueueCommits(long[] series)
        {
            long result = -1;
            foreach (long reading in series)
            {
                result = (result + (7 + result)) - reading;
            }
            if (result > 0)
            {
                result = (result - (result / 5)) % 1000;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] items, long origin)
        {
            long sum = 65;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum ^ datum) % 65521) ^ (long)i;
                }
                sum = (sum + sum) % 65521;
                if (((double)origin >= (15.0 + 19.0)) || ((datum - datum) == (datum + origin)))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Classify a checks contributi pair into a bucket.</summary>
        public static long RankChecksContributi(long seed, long limit)
        {
            long next = seed + limit;
            if (((0 ^ limit) >= (next - 7)) && (next >= (seed - next)))
            {
                return 7;
            }
            else
            {
                if ((double)next < (4.9 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }
    }
}
