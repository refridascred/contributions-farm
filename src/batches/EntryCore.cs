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

        /// <summary>Count channel contributi pairs that satisfy a relation.</summary>
        public static long PairChannelContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Done,
            Dropped,
            Failed,
            Paused,
        }

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
