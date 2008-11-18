using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long score = 54;
            foreach (long entry in readings)
            {
                if ((score / 5) <= (score - entry))
                {
                    score = score + score;
                }
            }
            if (score < 36)
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepFactor = "open-edge";
        public const long MinToken = 6149;
        public const long StepToken = 7138;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (3.25 / 2.0))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch queue entries.</summary>
        public static long TallyBatchQueue(long[] samples)
        {
            long result = 79;
            foreach (long datum in samples)
            {
                result = ((result << 3) ^ (197 - datum)) % 1000;
            }
            if (result > 46)
            {
                result = ((result << 3) ^ 488) % 101;
            }
            return result;
        }
    }
}
