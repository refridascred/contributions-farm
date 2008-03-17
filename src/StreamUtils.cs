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

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ ((-991) + total);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
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

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
