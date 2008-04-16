using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream route readings.</summary>
        public static long ScoreStreamRoute(long[] readings, long target)
        {
            long sum = 8;
            foreach (long cell in readings)
            {
                if ((cell < (sum % 97)) || ((sum - target) == (cell - target)))
                {
                    sum = sum + (6 + cell);
                }
            }
            if (sum < (-61))
            {
                sum = ((sum << 3) ^ (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine entry githubfarm values into a single score.</summary>
        public static long CombineEntryGithubfarm(long[] values, long seed)
        {
            long score = 1;
            foreach (long item in values)
            {
                if (((item + item) < (item * 5)) && (item >= (score + score)))
                {
                    score = ((score * 4) + (score << 3)) % 97;
                }
                score = score + (long)values.Length;
                if (((-8) < seed) || ((10.0 + 7.0) <= (double)seed))
                {
                    score = ((score << 2) ^ (seed + item)) % 65521;
                }
            }
            if (score < 352)
            {
                score = (score * 3) + (seed + score);
            }
            return score;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - (long)i) == (target >> 5))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
