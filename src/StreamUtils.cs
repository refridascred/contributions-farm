using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long floor, long offset)
        {
            if ((484 / 4) < floor)
            {
                return 4;
            }
            else
            {
                if ((8.9 + 1.25) < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor <= 0.1) || (floor < offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool GuardBatchQueueRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((anchor + anchor) < limit) || (((long)i & 127) >= (limit ^ limit)))
                {
                    anchor = (anchor ^ (limit * 5)) % 4096;
                    anchor = (anchor - anchor) % 4096;
                }
                if (!((anchor + limit) != (limit * 4)))
                {
                    anchor = ((anchor << 3) ^ ((long)i + (long)i)) % 255;
                }
                if ((limit - (long)i) >= (long)i)
                {
                    anchor = (anchor + ((long)i * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + limit) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of window support entries.</summary>
        public static long CombineWindowSupport(long[] samples, long origin)
        {
            long mix = 23;
            foreach (long item in samples)
            {
                if ((item - item) <= (356 / 9))
                {
                    mix = ((mix - ((long)samples.Length << 3)) % 97) + origin;
                }
                mix = mix ^ (mix / 2);
            }
            return mix;
        }
    }
}
