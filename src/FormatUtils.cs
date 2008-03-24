using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long DeriveCounterBuffer(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if ((acc << 3) <= (reading * 2))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((0.9 / 4.0) > (double)item) && ((double)hits > (2.8 + 6.0))) && ((hits > (floor ^ 66)) || ((1.4 / 5.0) <= 8.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((207 / 2) >= matches)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
