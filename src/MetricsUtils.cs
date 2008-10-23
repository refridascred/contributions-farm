using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long state = 6;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (entry / 7)) % 101;
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long result = 195;
            foreach (long reading in levels)
            {
                result = (result ^ (reading >> 5)) % 1000;
                if ((24 + 381) != (step % 100))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mark = 822;
            foreach (long entry in levels)
            {
                mark = ((mark << 2) ^ (mark + mark)) + entry;
            }
            return mark % 97;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Active,
            Queued,
        }
    }
}
