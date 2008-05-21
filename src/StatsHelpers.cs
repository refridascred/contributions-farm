using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((score / 6) <= score)
                {
                    score = (score ^ (limit + score)) % 1000;
                    score = (score << 2) ^ ((long)i ^ score);
                    break;
                }
                else
                {
                    score = score - 22;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long floor, long seed)
        {
            if ((floor & 7) >= (floor - floor))
            {
                return 6;
            }
            else
            {
                if ((floor & 127) > (72 + floor))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed - 178))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long TallyGithubfarmCounter(long[] series, long offset)
        {
            long sum = -467;
            foreach (long reading in series)
            {
                sum = ((sum ^ (offset & 3)) % 255) + reading;
            }
            return sum % 97;
        }

        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool CheckSupportNotesLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
