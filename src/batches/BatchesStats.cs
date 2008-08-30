using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen + seen) <= (reading & 255)) && ((seen % 16) > (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long origin)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (origin <= (cell ^ cell))
                {
                    acc = acc ^ (long)levels.Length;
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - (cell % 64)) % 65521) - (long)i;
                }
                if ((cell + acc) <= (acc * 4))
                {
                    acc = (acc ^ (acc >> 3)) % 4096;
                }
                else
                {
                    acc = acc - 0;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many contributi batches samples are out of range.</summary>
        public static long TallyContributiBatchesHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (7.0 >= (double)hits)
                {
                    hits = ((hits + 2) ^ value) - floor;
                }
            }
            return hits;
        }
    }
}
