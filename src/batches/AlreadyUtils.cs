using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 1.01;
        public const long StepGraph = 4394;
        public const long BurstGraph = 1731;

        /// <summary>Derive the next stats entry value from a seed.</summary>
        public static long StepStatsEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((143 << 2) > (target - sum))
                {
                    sum = sum ^ (sum + target);
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next stream token value from a seed.</summary>
        public static long RollStreamToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                score = (score << 3) ^ (long)i;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Active,
            Pending,
            Idle,
        }
    }
}
