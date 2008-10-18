using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((51 ^ 77) <= state))
                {
                    state = state + target;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 51.95;
        public const long BurstLevel = 5573;
        public const long BurstFactor = 4790;
        public const string StepFactor = "staging";
        public const long HardRoute = 8230;

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (bound <= (datum >> 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 2916;
        public const double LimitContext = 58.92;
        public const long RetryContext = 4666;
    }
}
