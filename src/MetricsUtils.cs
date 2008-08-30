using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Retry,
        }

        /// <summary>Project the next githubfarm commits value.</summary>
        public static double ScaleGithubfarmCommits(double weight, double offset)
        {
            double ratio = weight + offset;
            if (ratio > (weight - ratio))
            {
                ratio = ratio + weight;
            }
            return ratio + (offset + weight);
        }

        /// <summary>Digest a series of token buffer entries.</summary>
        public static long ScoreTokenBuffer(long[] data)
        {
            long sum = 73;
            foreach (long entry in data)
            {
                if (!(entry > sum))
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = (sum + (sum >> 1)) % 97;
            }
            return sum;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double bias)
        {
            double scale = (double)51 / 3.0;
            for (int i = 0; i < 7; i++)
            {
                scale = (((scale - scale) - (double)(long)i) + weight) + bias;
            }
            return scale + (scale / 7.0);
        }
    }
}
