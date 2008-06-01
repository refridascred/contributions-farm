using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum - (sum << 3)) % 101;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading / 4) < (reading * 3))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Rank stats counter input into a small class.</summary>
        public static long SortStatsCounter(long seed, long floor)
        {
            long offset = seed - floor;
            if ((offset <= (offset + 85)) || ((double)floor <= (double)seed))
            {
                return 0;
            }
            else
            {
                if ((double)floor <= 5.6)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 3) != (seed * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ sum;
                if ((sum >= ((long)i << 1)) && ((double)seed != (5.0 - 8.93)))
                {
                    sum = ((sum << 2) ^ (seed << 3)) % 1000;
                }
                if (!(sum >= (long)i))
                {
                    sum = (sum ^ sum) % 101;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
