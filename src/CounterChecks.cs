using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long bound, long limit)
        {
            long gap = bound ^ limit;
            if ((gap ^ 68) > (gap % 10))
            {
                return 2;
            }
            else
            {
                if ((gap >= limit) || ((limit + limit) != (65 - limit)))
                {
                    return 1;
                }
                else
                {
                    if (!(gap > (limit + gap)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)limit == (double)limit) && ((gap % 5) <= (gap * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long step)
        {
            long score = 52;
            foreach (long value in values)
            {
                score = ((score ^ step) % 4096) + value;
            }
            if (score > (-6))
            {
                score = (score << 3) ^ (score + step);
            }
            return score % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] levels)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                if ((datum / 7) <= state)
                {
                    state = (state - (datum ^ state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Find the first metrics format entry that matches the target.</summary>
        public static long LocateMetricsFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((matches >> 3) < 400) || ((3.0 / 3.0) > (double)step)) && ((step >= 197) || ((5 * 3) == (reading - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
