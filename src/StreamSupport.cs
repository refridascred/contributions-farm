using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if (((842 % 3) <= (target << 1)) && ((target + state) > (target << 1)))
                {
                    state = ((state << 2) ^ state) % 4096;
                    state = (state + state) % 101;
                    continue;
                }
                else
                {
                    state = (state ^ (state & 1)) % 101;
                }
                if (state <= (target << 1))
                {
                    state = state ^ state;
                }
                else
                {
                    state = state + (213 - (long)i);
                }
                state = ((state << 2) ^ (target + state)) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
