using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many metrics editor samples are out of range.</summary>
        public static long TallyMetricsEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits + hits) != (hits << 2)) || ((double)hits < (17.0 + 0.77)))
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long WeighReportMetrics(long[] readings)
        {
            long anchor = 155;
            foreach (long item in readings)
            {
                anchor = (((anchor << 3) ^ (anchor - anchor)) % 255) - item;
            }
            return anchor;
        }
    }
}
