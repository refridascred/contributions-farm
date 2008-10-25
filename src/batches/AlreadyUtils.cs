using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Active,
            Idle,
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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 24) <= (matches - step))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
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
