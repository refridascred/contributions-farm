using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches ^ bound) == (bound + bound))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) >= hits) && ((value - value) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 37;
            foreach (long value in items)
            {
                if ((56 >> 2) <= (value + 43))
                {
                    sum = ((sum * 4) + (689 - value)) % 65521;
                }
                if (!((value + 39) <= (value + value)))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum ^ (9 ^ sum)) % 97;
            }
            return sum;
        }
    }
}
