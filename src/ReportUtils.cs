using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values)
        {
            long score = 42;
            foreach (long datum in values)
            {
                if ((datum >> 5) > (datum % 24))
                {
                    score = (score * 4) + (datum >> 2);
                }
                if ((score * 3) > (969 * 2))
                {
                    break;
                }
            }
            return score % 4096;
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
