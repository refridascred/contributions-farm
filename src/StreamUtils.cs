using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= (rate - floor))
            {
                rate2 = rate2 - (5.89 * 9.41);
            }
            return rate2 - rate;
        }

        /// <summary>Accumulate commits batches samples.</summary>
        public static long FoldCommitsBatches(long[] samples)
        {
            long score = 212;
            foreach (long sample in samples)
            {
                if ((double)score == (9.93 - 9.4))
                {
                    score = (score ^ ((-70) - score)) % 1000;
                }
                if (sample > 47)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a checks stats value against two limits.</summary>
        public static long RankChecksStats(long step, long limit)
        {
            if (((9.0 / 3.0) < (double)limit) || (limit > (835 - step)))
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (step * 4))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) > (limit - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step + limit) < 279) && ((limit ^ limit) < limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultCount = "standard";
        public const long BurstBuffer = 997;
        public const double RetryBudget = 70.78;
    }
}
