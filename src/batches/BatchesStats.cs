using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Locked,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 5406;
        public const double StepSpan = 81.91;
        public const string BaseMetrics = "primary";
        public const long MaxWidth = 6715;
        public const long BatchScore = 7555;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue entry samples.</summary>
        public static long TallyQueueEntry(long[] samples)
        {
            long score = 414;
            foreach (long reading in samples)
            {
                score = score - (3 >> 3);
                if ((reading + 82) == (score << 3))
                {
                    score = score + (reading * 5);
                }
                else
                {
                    score = ((score * 5) + score) % 65521;
                }
                if (reading >= ((long)samples.Length + reading))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
