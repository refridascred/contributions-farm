using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                mark = (((mark * 3) + (entry << 3)) % 97) + target;
            }
            return mark;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long FoldAlreadyCounter(long[] levels, long step)
        {
            long state = 11;
            foreach (long datum in levels)
            {
                state = ((state + step) % 101) - datum;
                if ((state + 66) > state)
                {
                    state = (state ^ step) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally >> 1) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
