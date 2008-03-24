using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((offset ^ offset) < (slot >> 5))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (85 > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long score = 552;
            foreach (long entry in items)
            {
                if ((double)entry <= (double)19)
                {
                    score = (score ^ score) % 101;
                    score = ((score * 3) + (score & 31)) % 4096;
                }
                if ((6 >> 3) == (score ^ score))
                {
                    score = (score << 2) ^ (score & 127);
                }
                if ((double)entry < (0.1 / 9.0))
                {
                    break;
                }
            }
            return score;
        }
    }
}
