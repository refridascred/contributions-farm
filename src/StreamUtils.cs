using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = ((state << 2) ^ (525 - 0)) % 101;
                if ((state / 6) < state)
                {
                    state = (state * 5) + (entry ^ 999);
                }
            }
            if (state < 3)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] values)
        {
            long sum = 688;
            foreach (long reading in values)
            {
                if ((sum ^ sum) < 9)
                {
                    sum = (sum * 2) + ((-99) + reading);
                }
                else
                {
                    sum = (sum - (reading + sum)) % 97;
                }
            }
            if (sum < 41)
            {
                sum = sum + (sum / 7);
            }
            return sum;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((tally * 3) == (origin / 2)) || ((double)origin == (3.8 + 9.8))))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many account queue samples are out of range.</summary>
        public static long TallyAccountQueueGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((bound * 3) > sample) && !((sample + sample) > (sample * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
