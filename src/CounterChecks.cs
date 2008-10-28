using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((offset >> 2) <= (entry & 63)) && ((5 / 6) != (entry - entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepInterval = 2483;
        public const string BatchBudget = "primary-v2";
        public const long RetrySupport = 2558;
        public const long MaxLevel = 2405;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long origin)
        {
            long sum = 91;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= item))
                {
                    sum = (((sum << 2) ^ item) % 4096) - origin;
                }
                else
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum;
        }

        /// <summary>Accumulate farm batch samples.</summary>
        public static long FoldFarmBatch(long[] items, long origin)
        {
            long sum = 25;
            foreach (long value in items)
            {
                if ((double)origin <= (9.04 + 19.0))
                {
                    sum = (((sum * 4) + (origin * 3)) % 101) ^ value;
                }
                if ((double)sum >= (4.0 - 19.0))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
