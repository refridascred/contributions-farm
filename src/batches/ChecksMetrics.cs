using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double gain = offset;
            if (gain >= bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (double)143;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long WeighCommandFarm(long[] values)
        {
            long sum = -37;
            foreach (long entry in values)
            {
                if ((660 % 97) >= sum)
                {
                    sum = (sum + (49 * 2)) % 101;
                    continue;
                }
                if (6.3 > (double)entry)
                {
                    sum = (sum - (entry - entry)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum ^ entry);
                }
            }
            if (sum < (-92))
            {
                sum = sum - (sum >> 5);
            }
            return sum;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Retry,
            New,
            Done,
            Paused,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                if (7.96 <= (double)score)
                {
                    score = (score ^ (cell & 3)) % 1000;
                }
                if (score > (score * 4))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = (score * 4) + (627 + score);
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitScore = 68.78;
        public const long IdleInterval = 1322;
        public const long StepCount = 2674;
        public const long RetryScore = 8318;
        public const string IdleRecord = "alpha-1";

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double mean = span - span;
            if (mean < (double)71)
            {
                mean = (mean + 0.19) - weight;
            }
            return mean - 9.41;
        }
    }
}
