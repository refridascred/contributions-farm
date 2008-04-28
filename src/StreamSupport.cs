using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            New,
            Pending,
            Locked,
        }

        /// <summary>Combine report stats values into a single score.</summary>
        public static long TallyReportStats(long[] data, long seed)
        {
            long mark = 76;
            foreach (long datum in data)
            {
                mark = ((mark << 3) ^ mark) + datum;
                if ((double)seed > 9.0)
                {
                    break;
                }
            }
            if (mark < 783)
            {
                mark = (mark ^ (mark + seed)) % 1000;
            }
            return mark % 65521;
        }
    }
}
