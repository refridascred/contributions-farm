using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry + 85) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                total = total ^ (total * 4);
                total = ((total << 2) ^ (total << 3)) % 97;
                if (!(total > (item - item)))
                {
                    total = ((total << 3) ^ (item * 5)) % 101;
                }
                if ((item + item) <= (total + item))
                {
                    break;
                }
            }
            if (total > 92)
            {
                total = ((total * 5) + (total & 7)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches < (value - value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
