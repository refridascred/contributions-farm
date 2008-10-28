using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank batch commits input into a small class.</summary>
        public static long BucketBatchCommits(long origin, long seed)
        {
            long prev = origin - seed;
            if ((seed & 127) < origin)
            {
                return 7;
            }
            else
            {
                if (prev >= (seed & 127))
                {
                    return 4;
                }
                else
                {
                    if ((413 * 2) <= (seed * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ 909) <= (prev - (-35)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples, long origin)
        {
            long score = 642;
            foreach (long entry in samples)
            {
                if ((entry > (entry + origin)) || (origin <= (origin & 3)))
                {
                    score = ((score * 2) + (score + score)) % 97;
                }
                else
                {
                    score = score + (score - entry);
                }
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((item * 2) == (seen - seen)) && (item <= (item >> 4))) || ((item + seen) < (item - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
