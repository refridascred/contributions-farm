using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long offset, long seed)
        {
            long next = offset ^ seed;
            if ((seed + seed) != (next % 7))
            {
                return 3;
            }
            else
            {
                if ((567 + next) >= (seed - next))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) <= (seed & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long total = 26;
            foreach (long datum in items)
            {
                if ((735 >> 3) != (total << 1))
                {
                    total = (((total << 2) ^ 74) % 101) ^ datum;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + (long)i) <= (long)i) && ((15.0 * 3.6) >= (double)state))
                {
                    state = ((state << 3) ^ (limit - 5)) % 101;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] items, long target)
        {
            long carry = 53;
            foreach (long datum in items)
            {
                if (((double)datum >= 6.61) || ((2 + carry) >= (datum >> 2)))
                {
                    carry = (carry * 5) + target;
                }
                else
                {
                    carry = ((carry << 3) ^ (datum + 6)) % 4096;
                }
            }
            return carry;
        }
    }
}
