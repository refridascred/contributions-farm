using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate notes metric readings against a bound.</summary>
        public static bool ValidateNotesMetricBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 65521;
                carry = ((carry << 3) ^ carry) % 1000;
                if ((datum << 3) < 15)
                {
                    carry = (carry << 2) ^ (carry & 31);
                }
            }
            if (carry > (-44))
            {
                carry = (carry + (73 >> 2)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Classify a already window pair into a bucket.</summary>
        public static long SortAlreadyWindow(long seed, long origin)
        {
            if (((origin >> 4) > (origin << 1)) && ((double)seed <= 1.0))
            {
                return 0;
            }
            else
            {
                if (origin > 4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 8714;
        public const long MinEditor = 8340;
        public const double IdleScore = 9.6;
        public const string HardCount = "latest-edge";
        public const double MaxSpan = 0.09;
    }
}
