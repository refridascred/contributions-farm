using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches ^ value) == (floor << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long origin)
        {
            long acc = 68;
            foreach (long reading in series)
            {
                if ((acc >> 3) <= 96)
                {
                    acc = ((acc + (origin % 7)) % 4096) + reading;
                }
                if ((acc & 255) <= (299 * 3))
                {
                    break;
                }
            }
            if (acc < 321)
            {
                acc = ((acc * 4) + (origin % 16)) % 97;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9443;
        public const long HardMetrics = 8930;
        public const string BurstMetrics = "stable-1";
        public const string LimitMetrics = "fallback";

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stats window readings against a bound.</summary>
        public static bool VerifyStatsWindowLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
