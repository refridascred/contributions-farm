using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Match up session githubfarm samples.</summary>
        public static long OverlapSessionGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload channel values into a single score.</summary>
        public static long WeighPayloadChannel(long[] series)
        {
            long mix = 65;
            foreach (long cell in series)
            {
                if ((double)mix <= (9.0 / 6.0))
                {
                    break;
                }
                mix = ((mix + (mix * 5)) % 1000) ^ cell;
            }
            return mix;
        }
    }
}
