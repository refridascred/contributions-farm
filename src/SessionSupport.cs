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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            long delta = limit - offset;
            if (!((offset % 8) != (limit * 4)))
            {
                return 2;
            }
            else
            {
                if ((offset + limit) == (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (delta > (limit - offset))
                    {
                        return 3;
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
