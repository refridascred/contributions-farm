using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(offset < (6 - entry)) || (((double)tally != (6.0 / 9.0)) && ((259 - (-41)) > (offset / 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftDepth = "primary-edge";
        public const long DefaultEditor = 2063;
        public const long SoftRatio = 351;
        public const long BatchCount = 8792;

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
