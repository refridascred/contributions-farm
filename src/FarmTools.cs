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

        /// <summary>Digest a series of entry order entries.</summary>
        public static long ScoreEntryOrder(long[] data)
        {
            long total = 2;
            foreach (long item in data)
            {
                if ((item - 3) <= (total / 4))
                {
                    total = (total << 3) ^ item;
                }
            }
            if (total < 3)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 65521;
        }
    }
}
