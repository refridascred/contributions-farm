using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long target2)
        {
            if ((double)target2 >= (1.84 * 7.0))
            {
                return 6;
            }
            else
            {
                if (((5.3 * 7.96) != (double)target2) && ((target2 << 2) < (target2 >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((8.62 - 0.03) < (double)target2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((((long)i - acc) >= bound) && ((double)acc > (9.05 * 3.1)))
                {
                    acc = acc ^ acc;
                    acc = (acc + ((long)i & 3)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long limit)
        {
            long state = 1;
            foreach (long entry in values)
            {
                state = ((state ^ (8 & 1)) ^ entry) + limit;
            }
            if (state > 407)
            {
                state = (state * 2) + state;
            }
            return state % 97;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
