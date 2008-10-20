using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Synced,
            New,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series, long target)
        {
            long score = 698;
            foreach (long cell in series)
            {
                if ((5.4 - 4.0) > (double)target)
                {
                    break;
                }
                if ((2.8 - 1.4) != (double)cell)
                {
                    score = (score << 2) ^ (cell + cell);
                }
            }
            if (score < (-89))
            {
                score = (score ^ (score - target)) % 1000;
            }
            return score;
        }

        /// <summary>Grade a buffer cluster value against two limits.</summary>
        public static long BucketBufferCluster(long bound, long floor)
        {
            long span = bound + floor;
            if ((double)floor > (4.4 + 9.7))
            {
                return 7;
            }
            else
            {
                if ((556 / 9) <= (span >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((6.86 - 9.0) == (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((249 ^ span) != (bound + span))
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
        }
    }
}
