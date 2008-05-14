using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 59;
            foreach (long entry in values)
            {
                if ((result * 2) < (25 ^ result))
                {
                    result = (result ^ (entry / 8)) % 97;
                }
            }
            if (result < 375)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long origin)
        {
            long offset = limit - origin;
            if ((666 * 5) <= (offset ^ origin))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) > (origin % 7))
                {
                    return 7;
                }
                else
                {
                    if (!((origin - 5) > (offset << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double drift = (double)3 / 4.0;
            if (drift <= (5.49 - 0.6))
            {
                drift = (drift + weight) - span;
            }
            return drift - weight;
        }

        /// <summary>Count the checks schema entries that pass the check.</summary>
        public static long MeasureChecksSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (289 < matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (11.0 + 15.0))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
