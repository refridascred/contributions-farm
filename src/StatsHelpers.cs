using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long step)
        {
            if ((double)889 == (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step <= (step ^ seed)) || ((seed - seed) != (step % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 / 9.0) <= (double)step) && ((step * 2) > 89))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit editor route readings against a rule.</summary>
        public static long CountEditorRouteGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step + hits) > (75 & 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Failed,
            Synced,
            Closed,
        }
    }
}
