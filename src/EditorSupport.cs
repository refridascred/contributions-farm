using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2780;
        public const double MaxSize = 18.61;
        public const string CacheCommits = "primary-v2";

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long sample in series)
            {
                if (((-828) & 255) <= (sample / 7))
                {
                    anchor = ((anchor << 2) ^ (anchor * 2)) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 4.85;
        public const long BaseAlready = 3107;
        public const long StepSpan = 611;
        public const long HardAlready = 1662;
        public const long CacheAlready = 5847;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((0.07 * 5.0) >= (double)offset)
                {
                    total = (total * 2) + ((long)i % 8);
                }
                total = ((total * 3) + (total + (long)i)) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
