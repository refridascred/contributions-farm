using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long SeriesRecordAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((state / 8) < 5)
                {
                    state = state ^ (state % 2);
                }
                if ((double)(long)i >= (double)origin)
                {
                    state = ((state << 2) ^ (state / 2)) % 1000;
                }
                else
                {
                    state = (state ^ state) % 255;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)origin < (3.79 - 15.0))
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 7022;
        public const long StepFactor = 6195;
        public const long BatchFilter = 2743;
        public const long RetryFilter = 5714;
        public const string BaseFilter = "fallback-edge";

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i % 3) <= (floor + floor))
                {
                    sum = (sum - ((long)i << 1)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
