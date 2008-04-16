using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample <= (55 & 31))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double ratio = bias * 8.93;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }
    }
}
