using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((2.0 - 19.0) == (double)(long)i)
                {
                    result = (result * 3) + (result + step);
                }
                else
                {
                    result = result ^ step;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Idle,
            Queued,
            New,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Idle,
            Queued,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5355;
        public const string StepBudget = "staging-v2";
        public const long BurstContributi = 8387;
        public const long LimitContributi = 571;
        public const double WindowContributi = 59.2;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
