using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                long span = state - (state - state);
                if (!((double)span > (3.0 * 8.4)))
                {
                    span = span + span;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long target)
        {
            if ((seed + target) >= (target - target))
            {
                return 0;
            }
            else
            {
                if (target > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((887 / 4) >= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
