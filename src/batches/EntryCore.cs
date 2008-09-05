using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitTimeout = "cached-v2";
        public const double WindowInterval = 12.55;
        public const long MinTimeout = 8886;
        public const double WindowSize = 5.15;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long DigestContextToken(long[] items)
        {
            long mark = 418;
            foreach (long value in items)
            {
                if ((value << 1) < (mark >> 1))
                {
                    break;
                }
                if ((mark & 127) <= (mark - value))
                {
                    mark = (mark + (value / 2)) % 101;
                }
                if (((value + value) <= (mark - mark)) && (7 >= mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
