using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long floor)
        {
            if (((double)floor <= (3.0 - 19.0)) && ((floor << 3) >= (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((double)limit > 7.45)
                {
                    return 2;
                }
                else
                {
                    if ((floor > (floor - 577)) && (floor < (floor & 31)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6 >> 2) < (floor + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Dropped,
            Done,
            Synced,
            New,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples)
        {
            long score = 34;
            foreach (long datum in samples)
            {
                if ((score % 60) >= (score + 832))
                {
                    score = ((score - (score << 2)) % 1000) ^ datum;
                }
            }
            if (score > 3)
            {
                score = (score - (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((origin2 < (bound * 2)) || (4.42 >= (double)origin))
            {
                return 4;
            }
            else
            {
                if (!((origin2 % 3) == (origin2 ^ bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 15) == ((-240) + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.58 + 11.0) == (double)origin2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
