using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Idle,
            New,
            Synced,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long DigestLayoutBatches(long[] levels, long floor)
        {
            long state = 907;
            foreach (long value in levels)
            {
                state = ((state + (floor << 2)) % 255) + value;
            }
            if (state < 500)
            {
                state = state + state;
            }
            return state % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long seed)
        {
            long bound = limit ^ seed;
            if (!(63 <= (limit ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (6.9 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed & 255) > 73)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit % 5) <= (bound << 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (offset >= limit)
            {
                return 3;
            }
            else
            {
                if ((offset - offset) < limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Failed,
            New,
        }
    }
}
