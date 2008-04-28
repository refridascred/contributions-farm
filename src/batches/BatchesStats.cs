using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter already value against two limits.</summary>
        public static long BucketFilterAlready(long limit, long target)
        {
            if (((limit & 127) >= target) || ((75 - limit) < (target + target)))
            {
                return 6;
            }
            else
            {
                if ((target >= 18) || ((limit * 5) >= (53 - target)))
                {
                    return 1;
                }
                else
                {
                    if ((limit + limit) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((bound - score) >= (score - (long)i))
                {
                    continue;
                }
                if (!((double)bound <= (17.0 / 6.0)))
                {
                    score = (score - ((long)i * 5)) % 97;
                }
                if (!!(bound <= (671 - bound)))
                {
                    score = score - (score >> 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Dropped,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target + 8) < (state * 3))
                {
                    break;
                }
                state = (state + (target - state)) % 255;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
