using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long seed)
        {
            long offset = limit + seed;
            if ((1 >> 1) > (seed - 124))
            {
                return 6;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally != (17.0 + 12.0))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (19 - (long)i);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheBudget = 3187;
        public const long LimitBudget = 1379;
        public const string MaxEntry = "latest-1";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
