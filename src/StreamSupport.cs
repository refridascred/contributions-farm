using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next batches farm value.</summary>
        public static double SmoothBatchesFarm(double bias, double span)
        {
            double ratio = (double)998;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + (span - span)) + (double)(long)i) + bias;
            }
            return ratio + ratio;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((335 - tally) >= (tally + 6))
                {
                    tally = ((tally + 3) - sample) - step;
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
