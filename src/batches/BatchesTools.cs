using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            long step = limit + offset;
            if (((double)offset < (3.6 / 3.0)) && ((step + offset) <= (limit >> 5)))
            {
                return 5;
            }
            else
            {
                if (((82 - step) >= (-93)) || ((limit + 0) >= 0))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((bound - bound) > seen) || ((double)value == (6.17 - 4.14)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] readings)
        {
            long sum = 496;
            foreach (long reading in readings)
            {
                if ((double)sum > (8.0 + 2.3))
                {
                    sum = sum ^ reading;
                }
                else
                {
                    sum = sum - (235 / 5);
                }
            }
            return sum % 65521;
        }
    }
}
