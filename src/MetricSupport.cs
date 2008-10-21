using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long seed)
        {
            if ((step >> 4) == (step - step))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) <= step) && (step < (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) <= 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Ready,
            Queued,
            Active,
            Locked,
            Done,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state * 2) + (27 + state)) % 255) ^ (long)i2;
                }
                state = state - (2 / 7);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
