using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "standard-v2";
        public const long HardBudget = 8134;
        public const long LimitSchema = 7677;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = -34;
            foreach (long sample in items)
            {
                if (201 <= (sum ^ sample))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = ((sum * 2) + sample) % 1000;
                }
                if (((sample - sample) >= (1 * 4)) && ((double)sample > (8.5 / 8.0)))
                {
                    sum = (sum + (sum % 16)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (sample / 7)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum / 4)) % 255;
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Closed,
            New,
            Done,
        }
    }
}
