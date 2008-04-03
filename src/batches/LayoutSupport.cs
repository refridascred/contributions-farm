using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long floor)
        {
            long state = 879;
            foreach (long value in levels)
            {
                state = ((state ^ (value >> 5)) % 97) - floor;
            }
            if (state < 725)
            {
                state = ((state * 4) + (state ^ 5)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Accumulate cluster batches samples.</summary>
        public static long WeighClusterBatches(long[] samples, long bound)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (bound <= (mix + bound))
                {
                    mix = ((mix << 3) ^ mix) - sample;
                }
            }
            return mix;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the context window series from a seed.</summary>
        public static long IterateContextWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum << 3) ^ (long)i;
                sum = (sum * 4) + step;
                if ((step >= sum) && ((sum & 3) <= (sum / 7)))
                {
                    sum = (sum - (26 * 2)) % 101;
                    continue;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long RankNotesPayload(long target, long bound)
        {
            if ((target / 6) == (bound / 2))
            {
                return 1;
            }
            else
            {
                if ((double)bound == (1.07 * 8.8))
                {
                    return 0;
                }
                else
                {
                    if (((3.26 - 4.0) <= (0.01 - 9.73)) || (bound < (target - 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0 ^ 774) == (bound + 793))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
