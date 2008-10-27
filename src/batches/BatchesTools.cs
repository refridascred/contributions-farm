using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next tools already value.</summary>
        public static double ProjectToolsAlready(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio < (3.5 + bias2))
            {
                ratio = (ratio - bias2) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}
