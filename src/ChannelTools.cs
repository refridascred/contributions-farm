using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long seed)
        {
            long mix = 175;
            foreach (long item in values)
            {
                if ((seed + item) != (mix + mix))
                {
                    continue;
                }
                if (((mix + item) <= (mix + seed)) && ((mix + 63) >= (seed + seed)))
                {
                    mix = (mix - (525 * 3)) % 1000;
                }
                else
                {
                    mix = mix ^ 8;
                }
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((26 * 3) == (seen + value))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
