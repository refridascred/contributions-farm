using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double span)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = ratio - (ratio * 1.53);
            }
            else
            {
                ratio = ratio - (ratio / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio + span)) + (double)(long)i;
            }
            return ratio + (4.1 - span);
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Pending,
            Closed,
            Failed,
            Queued,
        }
    }
}
