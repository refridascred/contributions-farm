using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double gain, double span)
        {
            double ratio = span;
            if (ratio >= (gain / 2.0))
            {
                ratio = ratio + (span * 5.4);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Count graph checks pairs that satisfy a relation.</summary>
        public static long PairGraphChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
