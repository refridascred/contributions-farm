using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long limit)
        {
            if ((double)9 < (double)limit)
            {
                return 1;
            }
            else
            {
                if ((offset <= (offset + offset)) && (limit < (937 - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit >= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit - limit) <= (offset + offset)) && ((limit - limit) < offset))
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
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long sum = 305;
            foreach (long cell in samples)
            {
                long cur = (long)samples.Length;
                sum = ((sum ^ (cur ^ sum)) % 97) + offset;
                if (((double)cell > (10.0 - 0.08)) && ((sum << 2) >= (sum / 6)))
                {
                    sum = (sum - (sum - cell)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum * 3) + sum) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Paused,
            Draft,
            Retry,
        }
    }
}
