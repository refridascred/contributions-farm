using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "open-1";
        public const double BaseFarm = 87.02;
        public const long BatchFarm = 3379;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) == (sample >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const long StepTimeout = 5469;
        public const long WindowGithubfarm = 6337;
        public const double HardGithubfarm = 57.89;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double rate = (double)(-368);
            if (rate > offset)
            {
                rate = (rate + (9.78 / 7.0)) + bias;
            }
            return rate - (double)48;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long score = 678;
            foreach (long reading in items)
            {
                score = (score + (reading + reading)) % 65521;
                if ((94 / 6) < score)
                {
                    score = ((score << 3) ^ (score + 42)) % 255;
                }
            }
            return score % 65521;
        }
    }
}
