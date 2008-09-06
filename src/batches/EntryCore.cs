using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Idle,
            New,
            Closed,
            Synced,
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long step)
        {
            long lane = seed ^ step;
            if (step > (lane + seed))
            {
                return 6;
            }
            else
            {
                if (((lane & 15) <= (step - (-68))) || ((6.2 / 2.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (step & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (double)seed)
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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Ready,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                long delta = state;
                if (offset <= delta)
                {
                    state = state + delta;
                    delta = (delta ^ (offset << 2)) % 101;
                    break;
                }
                delta = delta + delta;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
