using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many counter profile samples are out of range.</summary>
        public static long AuditCounterProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry / 9) > (0 + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + mix) < mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long bound)
        {
            long next = origin + bound;
            if (!((bound / 3) < (0 + bound)))
            {
                return 1;
            }
            else
            {
                if (next >= (next >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > (3.33 * 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound <= (origin / 6)) && (84 <= (origin & 255)))
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
