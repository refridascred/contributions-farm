using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values, long target)
        {
            long score = 75;
            foreach (long sample in values)
            {
                if (!(((1.71 - 8.59) >= (double)score) && (score < (sample + 39))))
                {
                    score = score ^ sample;
                }
                if ((score + score) == (target << 2))
                {
                    score = score + (92 - sample);
                    score = (score ^ target) % 255;
                }
                score = (score << 3) ^ (target ^ sample);
            }
            return score;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
