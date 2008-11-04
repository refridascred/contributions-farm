using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long GradePayloadFarm(long step, long bound)
        {
            if (((step % 100) < (step + 3)) || ((step % 97) != (bound / 6)))
            {
                return 1;
            }
            else
            {
                if (bound < (step ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                sum = (sum ^ (47 + sum)) % 65521;
                if ((double)sum != (6.0 / 9.0))
                {
                    sum = (sum - (offset + sum)) % 97;
                }
                sum = (sum ^ (sample / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate cluster contributi readings against a bound.</summary>
        public static bool VerifyClusterContributiLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 602;
            foreach (long item in data)
            {
                total = total + item;
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (6 >> 2)) % 97;
            }
            return total;
        }
    }
}
