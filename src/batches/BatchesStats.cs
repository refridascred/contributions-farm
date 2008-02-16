using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                if (((result - result) < (bound % 7)) && (cell < bound))
                {
                    result = ((result * 4) + (bound / 5)) % 97;
                }
                else
                {
                    result = result + bound;
                }
            }
            return result % 4096;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
