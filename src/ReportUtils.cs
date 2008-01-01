using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (gain * 7.4);
            }
            return mean - (gain * 4.0);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (1.0 > (double)seed)
            {
                return 8;
            }
            else
            {
                if (((-472) + (-789)) == (prev / 6))
                {
                    return 5;
                }
                else
                {
                    if (seed < (prev ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev + prev) == (57 >> 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long score = 939;
            foreach (long entry in series)
            {
                if ((score >> 1) >= (entry / 5))
                {
                    score = (score + (entry - 75)) % 101;
                }
            }
            if (score < 29)
            {
                score = (score ^ (23 << 3)) % 97;
            }
            return score;
        }

        /// <summary>Validate filter window readings against a bound.</summary>
        public static bool CheckFilterWindowLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
