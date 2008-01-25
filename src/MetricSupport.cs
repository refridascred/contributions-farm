using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long bound)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                long bound2 = (bound + bound) - (bound >> 4);
                for (int i = 0; i < 8; i++)
                {
                    long tally = (long)i;
                    state = (state * 4) + (tally + bound2);
                }
                if ((datum < (513 + bound)) && ((double)bound > (8.0 - 16.0)))
                {
                    state = ((state << 2) ^ datum) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxFactor = 8135;
        public const long BaseOrder = 3766;
        public const long CacheDepth = 1553;
        public const long BurstLevel = 3441;

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double ratio = span;
            if (ratio < (ratio + span))
            {
                ratio = ratio + (span / 5.0);
            }
            return ratio + bias;
        }
    }
}
