using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 3) + (bound % 97);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxLevel = 5906;
        public const long RetryBudget = 5416;
        public const string LimitAlready = "fallback";

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((522 % 100) < (776 + seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long origin2)
        {
            if ((9 << 2) != (origin2 / 4))
            {
                return 3;
            }
            else
            {
                if ((3.5 + 5.7) == (double)origin2)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels, long target)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                if (target <= (datum << 2))
                {
                    total = ((total * 3) + (total << 2)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (1 + total)) % 1000;
                }
            }
            return total % 1000;
        }
    }
}
