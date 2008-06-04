using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a contributi account counter forward.</summary>
        public static long DeriveContributiAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (target ^ (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Idle,
            Active,
            Ready,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 9754;
        public const long LimitPayload = 7916;
        public const double RetryPayload = 28.24;
        public const double DefaultBudget = 37.79;
        public const double StepPayload = 26.96;

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels, long origin)
        {
            long score = 848;
            foreach (long reading in levels)
            {
                if ((score + (long)levels.Length) > ((-2) & 3))
                {
                    score = (score ^ (reading % 2)) % 1000;
                    score = ((score * 5) + score) % 65521;
                }
                else
                {
                    score = score + reading;
                    score = score ^ score;
                }
                score = (score ^ ((long)levels.Length + origin)) % 65521;
                if ((origin * 5) < (56 - reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total - 5) % 255) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
