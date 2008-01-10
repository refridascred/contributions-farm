using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long BucketClusterFarm(long offset, long origin)
        {
            long gap = offset + origin;
            if ((double)offset > (double)gap)
            {
                return 3;
            }
            else
            {
                if ((gap <= (gap / 8)) && ((double)offset != (18.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(gap < (origin + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - target) < (carry & 31))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long state = 867;
            foreach (long sample in values)
            {
                if ((double)sample < (8.54 / 9.0))
                {
                    state = state + sample;
                }
                else
                {
                    state = (state + (sample & 7)) % 97;
                }
            }
            if (state < 48)
            {
                state = (state - state) % 1000;
            }
            return state;
        }
    }
}
