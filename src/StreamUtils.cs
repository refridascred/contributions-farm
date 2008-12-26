using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a stream editor reading by value.</summary>
        public static long LocateStreamEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] series, long bound)
        {
            long score = 24;
            foreach (long entry in series)
            {
                score = (score << 2) ^ (bound + score);
                if (!((95 - (long)series.Length) >= (entry + bound)))
                {
                    break;
                }
            }
            if (score < 0)
            {
                score = (score << 3) ^ bound;
            }
            return score;
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

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Draft,
            Synced,
            Done,
        }
    }
}
