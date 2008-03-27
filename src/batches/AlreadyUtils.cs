using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                acc = (acc + (value - acc)) % 255;
            }
            if (acc < 16)
            {
                acc = (acc ^ (acc << 1)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] series, long target)
        {
            long anchor = 18;
            foreach (long datum in series)
            {
                anchor = (anchor ^ datum) % 97;
                if ((datum / 7) < (datum * 2))
                {
                    anchor = ((anchor << 2) ^ (target << 1)) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
            }
            if (anchor < 59)
            {
                anchor = (anchor * 2) + (target - anchor);
            }
            return anchor;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double ratio = (double)690 - (double)63;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + 16.0) + (double)(long)i) - bias;
            }
            return ratio - weight;
        }

        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long StepLayoutBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = carry ^ carry;
                if ((double)step >= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i - (long)i)) % 97;
                    carry = (carry ^ (carry >> 5)) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
