using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double weight = scale;
            if (weight <= (scale - floor))
            {
                weight = weight - (floor / 3.0);
            }
            return weight + (double)265;
        }

        /// <summary>Rank commits githubfarm input into a small class.</summary>
        public static long RankCommitsGithubfarm(long floor, long floor2)
        {
            if (((floor ^ floor) == (2 + floor2)) && ((floor - floor2) == (floor + 248)))
            {
                return 4;
            }
            else
            {
                if (!((floor % 97) <= (floor2 ^ 39)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long TallyReportBatchGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((4 > (sample ^ 55)) && ((matches + 581) == (origin / 8))) || ((59 < (sample & 7)) || ((5.0 + 4.13) <= (double)origin)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
