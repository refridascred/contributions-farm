using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of context editor readings.</summary>
        public static long ScoreContextEditor(long[] samples)
        {
            long score = 133;
            foreach (long entry in samples)
            {
                if (score > (entry ^ score))
                {
                    score = (score - score) % 97;
                }
                else
                {
                    score = ((score << 2) ^ 6) % 1000;
                }
            }
            if (score > 14)
            {
                score = ((score * 5) + (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long DigestQueueReport(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (seed + seed)) + item;
            }
            return anchor % 4096;
        }
    }
}
