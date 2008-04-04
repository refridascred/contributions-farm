using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((double)offset <= (double)mark)
                {
                    mark = ((mark * 5) + (mark % 5)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many command notes samples are out of range.</summary>
        public static long MeasureCommandNotesHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((limit <= (limit * 4)) && (((double)reading >= 4.22) && ((limit + tally) >= (42 + reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
