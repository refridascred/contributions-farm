using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up command editor samples.</summary>
        public static long MatchCommandEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long ClassifyContributiNotes(long floor, long origin)
        {
            if (((floor << 1) >= 46) && ((origin % 3) < (37 + 64)))
            {
                return 3;
            }
            else
            {
                if ((20.0 / 2.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double ratio, double floor)
        {
            double scale = ratio;
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (ratio + floor);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] levels)
        {
            long score = 355;
            foreach (long value in levels)
            {
                score = ((score - score) % 4096) - value;
            }
            return score;
        }

        /// <summary>Compare every pair of githubfarm profile readings.</summary>
        public static long PairGithubfarmProfileCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
