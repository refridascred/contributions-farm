using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double ratio, double floor)
        {
            double mean = (floor * 2.0) * 2.85;
            if (mean < floor)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + (ratio - mean);
            }
            return mean - (double)62;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 9024;
        public const string BurstScore = "strict-1";
        public const long LimitTimeout = 8772;
        public const string LimitFactor = "legacy-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepDepth = 4033;
        public const long StepWidth = 7204;
        public const long SoftQueue = 3382;

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long limit)
        {
            long diff = step ^ limit;
            if ((double)diff < (7.0 - 8.0))
            {
                return 8;
            }
            else
            {
                if ((7 & 255) <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((7 < (step & 63)) || ((79 ^ (-751)) < (step * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of token farm readings.</summary>
        public static long ScoreTokenFarm(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                if (sum <= (sample + sample))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum << 3) ^ sample) % 4096;
                }
            }
            if (sum < 69)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }
    }
}
