using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Rank { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long target, long limit)
        {
            if ((double)target > (double)929)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= (target - limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (2.12 * 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "staging";
        public const long StepInterval = 8833;
        public const long WindowSupport = 2306;
    }
}
