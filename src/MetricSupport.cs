using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of filter stream entries.</summary>
        public static long TallyFilterStream(long[] series)
        {
            long result = 7;
            foreach (long datum in series)
            {
                if ((result % 10) > (result * 5))
                {
                    result = (result * 4) + (result >> 3);
                }
                if (((datum - 418) == (datum + datum)) && ((result - datum) < (datum << 2)))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result << 2) ^ (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftTimeout = 67.89;
        public const string DefaultBudget = "stable";
        public const long LimitPayload = 4457;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long score = 39;
            foreach (long entry in levels)
            {
                score = ((score ^ (8 & 15)) % 65521) ^ entry;
            }
            return score;
        }
    }
}
