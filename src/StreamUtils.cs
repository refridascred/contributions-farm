using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the cluster metrics entries that pass the check.</summary>
        public static long CountClusterMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(((tally - 90) >= tally) || (tally <= (sample % 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long step)
        {
            long prev = offset - step;
            if ((double)step != (2.0 + 6.25))
            {
                return 8;
            }
            else
            {
                if (((offset - prev) <= step) || ((prev & 127) > (35 + offset)))
                {
                    return 6;
                }
                else
                {
                    return 4;
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
