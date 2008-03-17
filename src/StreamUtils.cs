using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many window filter samples are out of range.</summary>
        public static long MeasureWindowFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)value < (3.3 * 9.99))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long TallyBatchesReportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches < (13 - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long target)
        {
            long lane = offset + target;
            if ((42 >= target) && ((offset - 99) >= (lane - offset)))
            {
                return 0;
            }
            else
            {
                if (!((lane ^ target) > (offset - target)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long floor)
        {
            long state = 60;
            foreach (long sample in data)
            {
                state = ((state + (floor + state)) % 1000) + sample;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8435;
        public const long BaseGraph = 3522;
        public const long DefaultScore = 9652;
        public const long BurstSpan = 3390;
        public const long BurstRatio = 2566;
    }
}
