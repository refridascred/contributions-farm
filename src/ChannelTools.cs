using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch metrics entries that pass the check.</summary>
        public static long CountBatchMetricsGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((2.7 - 3.5) > (double)reading) && (seen >= (seen % 10)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long step, long target)
        {
            long cur = step ^ target;
            if (!(target <= (target + 8)))
            {
                return 0;
            }
            else
            {
                if (((target & 255) >= (target % 5)) || (cur >= (target % 7)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
