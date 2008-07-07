using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool VerifyFarmBatchLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Idle,
            Closed,
            New,
            Locked,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long seed)
        {
            long prev = offset + seed;
            if (((double)offset != (double)93) || ((seed & 63) >= seed))
            {
                return 0;
            }
            else
            {
                if (25 > (offset - prev))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long sum = 35;
            foreach (long value in series)
            {
                if ((value << 1) == (value - 7))
                {
                    sum = ((sum * 3) + (value / 2)) % 4096;
                    sum = (sum << 2) ^ sum;
                    continue;
                }
                if (5.4 < (double)value)
                {
                    sum = ((sum * 4) + (sum + value)) % 255;
                    sum = (sum ^ (622 >> 5)) % 65521;
                }
                if (((0 << 1) >= (sum << 2)) && ((double)3 <= (double)sum))
                {
                    sum = (sum ^ 864) % 97;
                }
                else
                {
                    sum = sum - 857;
                }
            }
            if (sum < 9)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long MeasureBufferWindowGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits > 5.74) || (((double)sample <= 5.0) || ((sample + sample) >= (hits >> 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
