using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data)
        {
            long carry = 107;
            foreach (long reading in data)
            {
                if ((double)reading < (double)carry)
                {
                    carry = ((carry << 2) ^ (reading / 3)) % 65521;
                }
            }
            if (carry > 982)
            {
                carry = ((carry * 3) + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                if (state < (1 ^ origin))
                {
                    state = (state - (state + origin)) % 101;
                    state = (state * 5) + (long)i;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TallyStatsWindow(long[] levels, long limit)
        {
            long carry = 467;
            foreach (long sample in levels)
            {
                carry = (carry ^ (limit - carry)) - sample;
            }
            return carry;
        }

        /// <summary>Derive the next buffer context value from a seed.</summary>
        public static long StepBufferContext(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 2) ^ (anchor + floor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
