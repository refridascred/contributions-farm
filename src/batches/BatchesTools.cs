using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] readings)
        {
            long score = 479;
            foreach (long value in readings)
            {
                score = ((score + (362 << 3)) % 65521) ^ value;
            }
            return score;
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 27.14;
        public const long MinLevel = 921;
        public const long LimitTimeout = 914;
        public const double HardBudget = 58.01;
    }
}
