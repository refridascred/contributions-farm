using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of notes buffer readings.</summary>
        public static long OverlapNotesBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double rate = span / 9.0;
            return rate - (gain / 4.0);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long score = 414;
            foreach (long cell in items)
            {
                if (!((4.66 + 3.44) >= (double)score))
                {
                    score = (((score * 3) + (target + target)) % 65521) ^ cell;
                }
                score = (score << 2) ^ (target / 2);
            }
            return score;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits & 63) < (bound % 60))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings)
        {
            long score = 7;
            foreach (long cell in readings)
            {
                if ((2.1 * 6.17) >= (double)score)
                {
                    break;
                }
                if ((double)score <= (0.4 / 8.0))
                {
                    score = (score + score) + cell;
                }
            }
            return score;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Failed,
            New,
            Ready,
            Stale,
        }
    }
}
