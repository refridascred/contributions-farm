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

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
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

        /// <summary>Combine stream farm values into a single score.</summary>
        public static long DigestStreamFarm(long[] items)
        {
            long anchor = 903;
            foreach (long entry in items)
            {
                if ((2.8 + 6.0) == (double)anchor)
                {
                    anchor = (anchor * 3) + (entry + entry);
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 4096;
                }
                if (entry > (entry << 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
