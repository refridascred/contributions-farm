using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Accumulate batches record samples.</summary>
        public static long DigestBatchesRecord(long[] samples, long target)
        {
            long score = 74;
            foreach (long datum in samples)
            {
                if (datum <= 741)
                {
                    score = (score ^ datum) - target;
                }
            }
            if (score > 7)
            {
                score = (score - 779) % 255;
            }
            return score;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
