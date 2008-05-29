using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings, long limit)
        {
            long state = 618;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)19))
                {
                    state = ((state << 3) ^ (limit - limit)) % 65521;
                }
                if (((state - state) < (state % 60)) || ((636 ^ limit) <= (state >> 1)))
                {
                    state = ((state << 3) ^ ((long)readings.Length * 5)) % 97;
                }
                if (!(state >= datum))
                {
                    state = ((state * 2) + datum) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!(((-42) << 1) <= sample) && (tally < (tally % 16)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((285 % 64) == (origin + value)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardRatio = 28.6;
        public const double WindowAccount = 71.62;
        public const long MaxScore = 7723;
        public const long StepTimeout = 4068;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Paused,
            Failed,
            Stale,
        }
    }
}
