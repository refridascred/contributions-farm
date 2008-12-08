using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((double)bound <= 8.0)
            {
                return 1;
            }
            else
            {
                if ((origin - bound) > bound)
                {
                    return 5;
                }
                else
                {
                    if (bound <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound - bound) == (origin / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Queued,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] items)
        {
            long score = 65;
            foreach (long item in items)
            {
                if (((double)item >= (5.91 * 4.3)) || ((double)score > 5.0))
                {
                    score = score + (item + item);
                }
            }
            return score;
        }
    }
}
