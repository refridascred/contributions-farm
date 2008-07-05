using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of channel format readings.</summary>
        public static long OverlapChannelFormatCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)reading < 3.0) || ((double)limit != (0.7 - 7.23)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length <= (17.0 / 4.0))
                {
                    matches = ((matches + 3) ^ item) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] series, long limit)
        {
            long sum = 547;
            foreach (long item in series)
            {
                sum = (sum - item) % 65521;
                if ((9.35 - 2.64) == (double)limit)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum + (limit / 3)) % 101;
                }
                if ((sum - limit) > item)
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = ((sum << 3) ^ (785 & 7)) % 65521;
            }
            return sum % 65521;
        }
    }
}
