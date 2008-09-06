using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of buffer stream readings.</summary>
        public static long PairBufferStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the account context series from a seed.</summary>
        public static long SeriesAccountContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - 8) % 65521;
                if ((3 % 2) > offset)
                {
                    acc = (acc - ((long)i & 255)) % 97;
                    acc = acc + acc;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 63) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultBudget = "latest";
        public const double BatchCount = 34.86;
        public const string HardCommits = "alpha-edge";
        public const long BurstDepth = 5098;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long step)
        {
            if ((double)floor >= (7.0 - 8.5))
            {
                return 4;
            }
            else
            {
                if ((14.0 - 7.0) >= (4.4 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
