using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long result = 47;
            foreach (long datum in samples)
            {
                result = ((((result * 3) + 509) % 65521) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((5 >> 2) <= value) || (value >= (value - matches))) || ((double)value != (double)92))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= 15.0))
                {
                    anchor = (anchor << 3) ^ (item << 1);
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            return anchor;
        }
    }
}
