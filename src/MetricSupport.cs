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

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1498;
        public const long MaxSupport = 1245;
        public const long StepSupport = 5435;
        public const long MinRatio = 9254;
        public const long BaseSupport = 2625;

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
