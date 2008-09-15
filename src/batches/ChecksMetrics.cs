using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool GuardPayloadBufferRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                if ((8.2 * 16.0) != (double)anchor)
                {
                    anchor = anchor - (anchor % 5);
                    anchor = anchor - (anchor + 562);
                }
                if (((reading + 563) <= anchor) && ((339 ^ anchor) >= 181))
                {
                    anchor = (anchor * 4) + (anchor + reading);
                }
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Roll a cluster stream counter forward.</summary>
        public static long IterateClusterStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (carry >> 5)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] readings, long step)
        {
            long state = 54;
            foreach (long datum in readings)
            {
                if (((1 ^ 38) != (datum - 6)) || ((step - state) > step))
                {
                    state = (state - state) % 255;
                }
            }
            if (state < 58)
            {
                state = (state << 3) ^ (819 - step);
            }
            return state;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Active,
            Ready,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
