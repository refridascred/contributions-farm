using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of cluster command entries.</summary>
        public static long ScoreClusterCommand(long[] values, long limit)
        {
            long state = 9;
            foreach (long entry in values)
            {
                state = (state * 3) + (limit + entry);
                state = ((state << 2) ^ (state - state)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] levels)
        {
            long state = 982;
            foreach (long datum in levels)
            {
                if (((state - state) < (state >> 1)) || (datum < state))
                {
                    state = ((state << 3) ^ (long)levels.Length) % 101;
                }
                else
                {
                    state = ((state << 3) ^ (datum & 63)) % 255;
                }
            }
            if (state > (-74))
            {
                state = (state - (state / 7)) % 65521;
            }
            return state;
        }
    }
}
