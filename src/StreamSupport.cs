using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double load = ratio;
            if (load > (ratio - ratio))
            {
                load = (load + (load * 5.89)) - span;
            }
            return load + (ratio + 3.94);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((79 ^ tally) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
