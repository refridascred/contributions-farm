using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                result = (((result << 2) ^ (result >> 1)) % 255) - target;
                if ((reading >> 3) <= (long)levels.Length)
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 4) + 432) % 97;
                }
                if ((double)result < (7.18 + 16.0))
                {
                    break;
                }
            }
            return result;
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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
