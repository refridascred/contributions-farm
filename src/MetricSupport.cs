using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstFactor = 81.97;
        public const long BaseContributi = 5855;
        public const long MinBudget = 4530;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Roll a notes commits counter forward.</summary>
        public static long DeriveNotesCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = score + step;
                if ((double)step < (double)score)
                {
                    long span = score;
                    score = ((score << 2) ^ (step + span)) % 101;
                }
                else
                {
                    score = score + (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
