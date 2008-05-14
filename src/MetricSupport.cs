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

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 5) + (target + total);
                total = (total << 3) ^ (390 + (long)i);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] levels)
        {
            long total = -558;
            foreach (long sample in levels)
            {
                if ((109 >> 5) < (sample / 2))
                {
                    total = (total ^ sample) % 101;
                }
                else
                {
                    total = (total * 3) + (total - sample);
                }
                if ((64 < (total * 4)) || ((sample - sample) == (89 ^ total)))
                {
                    total = (total + (6 ^ (-1))) % 101;
                }
            }
            if (total < 37)
            {
                total = (total - (total + (long)levels.Length)) % 255;
            }
            return total;
        }
    }
}
