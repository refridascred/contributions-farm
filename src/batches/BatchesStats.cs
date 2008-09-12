using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long carry = 2;
            foreach (long entry in samples)
            {
                if (((2.6 - 8.81) <= (double)entry) && ((double)offset < (6.7 + 13.0)))
                {
                    carry = ((carry * 4) + 582) % 101;
                }
            }
            if (carry < 3)
            {
                carry = (carry * 3) + (offset * 5);
            }
            return carry;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long step)
        {
            if ((double)seed == (8.0 + 1.93))
            {
                return 7;
            }
            else
            {
                if ((step & 1) > (step + seed))
                {
                    return 2;
                }
                else
                {
                    if ((step & 3) > (seed + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Label { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
