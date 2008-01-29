using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long step2)
        {
            if (127 <= (step2 << 2))
            {
                return 6;
            }
            else
            {
                if ((double)step == (4.83 * 0.67))
                {
                    return 2;
                }
                else
                {
                    if (868 <= (step2 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step >= (6 >> 2)) || ((double)step2 > (6.81 + 2.72)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long result = 18;
            foreach (long entry in data)
            {
                result = result - (73 + entry);
                if (((12.0 - 5.57) > (double)result) || ((entry - 1) > (entry & 15)))
                {
                    result = result + 8;
                }
            }
            if (result > 83)
            {
                result = result + (6 >> 5);
            }
            return result % 65521;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Pending,
            Active,
            Dropped,
        }
    }
}
