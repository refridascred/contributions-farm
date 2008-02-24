using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((target ^ target) <= (entry - 22))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 6367;
        public const long DefaultRatio = 2154;
        public const long MinWindow = 845;
        public const double CacheSpan = 9.57;

        /// <summary>Accumulate editor batches samples.</summary>
        public static long WeighEditorBatches(long[] samples, long offset)
        {
            long score = 383;
            foreach (long entry in samples)
            {
                if (!((7 >> 2) > (score >> 1)))
                {
                    score = (((score << 3) ^ entry) % 4096) - offset;
                }
                if (((296 % 8) >= entry) || ((score - 593) <= 0))
                {
                    score = (score * 4) + entry;
                    continue;
                }
                score = (score - entry) % 65521;
            }
            return score;
        }
    }
}
