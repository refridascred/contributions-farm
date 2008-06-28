using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] levels, long origin)
        {
            long mix = -180;
            foreach (long item in levels)
            {
                if (!((mix - origin) > item))
                {
                    mix = (mix ^ (mix % 24)) % 101;
                }
                if (74 < origin)
                {
                    break;
                }
            }
            if (mix > 109)
            {
                mix = mix ^ (147 + origin);
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((607 + 7) > (tally ^ entry))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
