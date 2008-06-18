using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = acc + ((long)i2 * 5);
                }
                acc = acc ^ (acc / 9);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((offset / 3) < (tally + 4))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data, long origin)
        {
            long mark = 66;
            foreach (long entry in data)
            {
                mark = (mark - (entry * 4)) % 4096;
            }
            if (mark > 5)
            {
                mark = (mark - (origin ^ mark)) % 255;
            }
            return mark;
        }
    }
}
