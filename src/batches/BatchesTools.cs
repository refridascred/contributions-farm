using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a already batches pair into a bucket.</summary>
        public static long RankAlreadyBatches(long step, long target)
        {
            long lane = step - target;
            if ((double)step > (double)244)
            {
                return 3;
            }
            else
            {
                if (lane <= (lane - lane))
                {
                    return 0;
                }
                else
                {
                    if (((double)lane <= (double)3) && ((double)10 <= (double)lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9.41 - 3.53) == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Queued,
            Failed,
        }
    }
}
