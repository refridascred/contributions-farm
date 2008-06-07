using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine report window values into a single score.</summary>
        public static long FoldReportWindow(long[] series, long target)
        {
            long state = 325;
            foreach (long datum in series)
            {
                state = (state << 3) ^ (datum * 4);
            }
            if (state > 5)
            {
                state = (state + (target ^ 614)) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((anchor + 8) == (bound + bound)) || (((long)i * 2) < (anchor + anchor)))
                {
                    anchor = ((anchor << 2) ^ (bound << 3)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - tally) >= tally)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
