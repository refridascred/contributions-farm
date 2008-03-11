using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry % 12) > (matches ^ entry))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the window checks entries that pass the check.</summary>
        public static long AuditWindowChecksHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen % 100) >= seen)
                {
                    seen = ((seen + 2) ^ cell) - offset;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long DigestBatchesToken(long[] data)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (!((double)entry <= (5.64 / 8.0)))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = (result ^ (48 - result)) % 97;
                if (((result & 3) <= (46 - 69)) || ((double)979 < (double)entry))
                {
                    result = (result - (result * 3)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items)
        {
            long sum = -10;
            foreach (long value in items)
            {
                if ((4 & 255) != (value * 3))
                {
                    sum = ((sum << 3) ^ (value ^ value)) % 97;
                }
            }
            return sum % 65521;
        }
    }
}
