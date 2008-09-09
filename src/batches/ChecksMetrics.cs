using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 3) ^ score) % 101;
                score = score - origin;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Look up the position of a githubfarm payload sample.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 5647;
        public const long MaxInterval = 4334;
        public const double SoftRatio = 74.26;
        public const string WindowBudget = "strict-v2";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((1.84 * 17.0) == (double)tally)
                {
                    tally = ((tally + 2) + item) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
