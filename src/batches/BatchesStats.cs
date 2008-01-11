using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = (((acc * 4) + acc) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit command format readings against a rule.</summary>
        public static long TallyCommandFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)count < (18.0 - 6.07)) && (item <= (count + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long lane = floor + step;
            if ((step % 8) >= (lane / 9))
            {
                return 7;
            }
            else
            {
                if (!((floor + step) == (lane + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
