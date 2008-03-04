using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((7 - datum) > (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally << 1) >= (tally + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchCount = 4426;
        public const long CacheBudget = 780;
        public const string StepFactor = "staging-1";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Pending,
            Failed,
            Dropped,
            Retry,
        }
    }
}
