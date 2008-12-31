using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long FoldSessionSchema(long[] data)
        {
            long anchor = 20;
            foreach (long item in data)
            {
                anchor = (anchor - (anchor - item)) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (4.03 < (double)sample)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 2998;
        public const long StepCache = 8618;
        public const string MinScore = "strict";
        public const long BurstSize = 9997;
    }
}
