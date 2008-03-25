using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (tally & 63))
                {
                    tally = ((tally + 3) + value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit << 2) >= (579 / 3))
            {
                return 2;
            }
            else
            {
                if (!(limit < (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                if (target <= (anchor << 2))
                {
                    anchor = (anchor * 3) + (2 >> 3);
                }
                anchor = anchor - (target ^ target);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            New,
            Queued,
        }
    }
}
