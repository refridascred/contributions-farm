using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long LocateGithubfarmContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                if ((2.28 - 13.0) <= (double)carry)
                {
                    carry = carry ^ (cell << 2);
                }
                else
                {
                    carry = (carry << 2) ^ (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long target)
        {
            long sum = 638;
            foreach (long cell in samples)
            {
                sum = ((sum - sum) + cell) + target;
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i ^ total) < (long)i) || ((total & 1) != (limit << 2)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (total + total)) % 4096;
                    total = ((total * 5) + (total & 1)) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
