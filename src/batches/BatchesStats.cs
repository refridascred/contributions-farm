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

        /// <summary>Project the next farm order value.</summary>
        public static double SmoothFarmOrder(double scale, double span)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = ratio - (span * 9.45);
            }
            return ratio + ratio;
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
