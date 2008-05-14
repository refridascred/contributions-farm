using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Closed,
            Ready,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 2696;
        public const long LimitSession = 3215;
        public const long CacheLevel = 7446;

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long FoldNotesBatch(long[] samples, long target)
        {
            long mix = 554;
            foreach (long datum in samples)
            {
                long tally = datum;
                if (((datum / 3) > (target * 5)) && ((double)target < (double)tally))
                {
                    tally = ((tally * 4) + (607 % 100)) % 1000;
                }
                else
                {
                    tally = tally ^ (mix ^ mix);
                }
                if (((double)2 >= (double)mix) || (target < (target + datum)))
                {
                    mix = (mix + mix) % 97;
                }
                if ((datum ^ mix) != (mix & 31))
                {
                    break;
                }
            }
            if (mix < 59)
            {
                mix = ((mix * 3) + ((long)samples.Length ^ 6)) % 101;
            }
            return mix;
        }
    }
}
