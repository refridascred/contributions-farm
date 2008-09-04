using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftTimeout = "staging";
        public const long WindowChecks = 2727;
        public const string BurstLevel = "alpha";

        /// <summary>Fold a list of metric stream readings.</summary>
        public static long FoldMetricStream(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry >> 1) != (entry / 4))
                {
                    long cur = (entry * 3) & 3;
                    state = (state * 2) + (state + cur);
                }
                if ((6.0 - 6.0) > (double)state)
                {
                    state = (state * 2) + (entry / 2);
                }
                else
                {
                    state = state ^ (entry + (long)values.Length);
                }
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
