using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Idle,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Rank cache payload input into a small class.</summary>
        public static long BucketCachePayload(long target, long step)
        {
            long step2 = target ^ step;
            if ((double)target == (double)577)
            {
                return 3;
            }
            else
            {
                if ((step2 << 1) < (step / 3))
                {
                    return 6;
                }
                else
                {
                    if ((step <= ((-94) % 60)) || ((step2 / 3) < (step2 + step2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target < (step2 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long floor)
        {
            if (bound < (floor - floor))
            {
                return 1;
            }
            else
            {
                if (((floor << 1) != ((-22) % 24)) || ((5.98 * 7.0) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ 37) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < (3.0 / 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Ready,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = (((state * 3) + state) % 65521) - cell;
            }
            if (state < 6)
            {
                state = state + 30;
            }
            return state;
        }
    }
}
