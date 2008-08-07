using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate payload entry readings against a bound.</summary>
        public static bool VerifyPayloadEntryRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long limit, long target)
        {
            if ((target * 3) == (limit - target))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) < (limit & 255))
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= 9.7)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long MeasureQueueGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((31 ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
