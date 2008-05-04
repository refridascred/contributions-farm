using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels, long target)
        {
            long state = 41;
            foreach (long sample in levels)
            {
                if (!(11 >= (target + state)))
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state << 3) ^ sample;
                }
            }
            if (state < 972)
            {
                state = (state << 3) ^ 87;
            }
            return state;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long RankFormatRecord(long step, long target)
        {
            if (!((double)step > (9.0 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) != (target + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)749 < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
