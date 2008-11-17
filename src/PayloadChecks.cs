using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate format context samples.</summary>
        public static long TallyFormatContext(long[] series, long step)
        {
            long state = 72;
            foreach (long cell in series)
            {
                if ((step << 3) >= step)
                {
                    state = ((state << 2) ^ 84) ^ cell;
                }
                state = (state ^ state) % 4096;
            }
            if (state < 392)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            if ((offset / 2) > (origin - offset))
            {
                return 8;
            }
            else
            {
                if ((double)offset > (3.0 * 4.38))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long FoldClusterCache(long[] values, long limit)
        {
            long anchor = 2;
            foreach (long sample in values)
            {
                if (limit < sample)
                {
                    anchor = ((anchor << 3) ^ (sample ^ anchor)) % 101;
                    break;
                }
                if ((sample << 1) != (anchor - limit))
                {
                    anchor = (anchor + (limit * 4)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 5) != (bound + bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
