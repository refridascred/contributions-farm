using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long CountFormatStreamGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry > 7)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings)
        {
            long sum = -3;
            foreach (long reading in readings)
            {
                sum = ((sum << 2) ^ reading) % 97;
                if (sum < (reading ^ 5))
                {
                    sum = (sum - (sum - reading)) % 97;
                }
                if (((11.0 + 8.4) <= (double)reading) || ((reading ^ reading) > (sum ^ sum)))
                {
                    break;
                }
            }
            if (sum < (-671))
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 905;
        public const double RetryCount = 8.97;
        public const double BurstContext = 75.44;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 1378;
        public const string SoftTools = "latest-1";
        public const long LimitInterval = 2204;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score - (sample - sample)) % 101;
            }
            return score % 65521;
        }
    }
}
