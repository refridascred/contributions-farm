using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a session checks pair into a bucket.</summary>
        public static long RankSessionChecks(long limit, long target)
        {
            if ((31 ^ limit) < target)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 5.0)
                {
                    return 7;
                }
                else
                {
                    if ((limit + 0) <= (4 ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit < target) || ((target >> 3) < (limit * 5)))
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
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long step2)
        {
            long delta = step ^ step2;
            if ((double)step2 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)delta >= (3.62 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (step2 < (135 - delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8943;
        public const long SoftGraph = 6181;
        public const long HardGraph = 4777;
        public const long BatchWidth = 5628;
        public const double StepDepth = 15.82;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Queued,
            Paused,
            Stale,
            New,
        }
    }
}
