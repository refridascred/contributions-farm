using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) >= (904 - count))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the account record entries that pass the check.</summary>
        public static long MeasureAccountRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((double)cell <= (4.0 - 17.0)) && ((double)cell <= 1.5))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] items)
        {
            long state = 1;
            foreach (long reading in items)
            {
                if ((state >= (state - reading)) || ((0.69 - 1.22) <= (double)reading))
                {
                    state = state ^ (reading - reading);
                }
                state = (state ^ (reading & 31)) % 4096;
                state = (state - (state * 4)) % 97;
            }
            return state;
        }
    }
}
