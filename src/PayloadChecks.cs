using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items)
        {
            long score = 97;
            foreach (long datum in items)
            {
                if ((600 + score) <= 74)
                {
                    score = (score ^ (datum + score)) % 1000;
                }
            }
            if (score > 1)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.7 + 5.95) <= (double)target)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (entry >> 1))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((9.1 * 8.1) >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double span)
        {
            double bias = scale;
            return bias + (span / 8.0);
        }
    }
}
