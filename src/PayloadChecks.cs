using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long state = -68;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ (state - state)) % 255;
                state = (state - (cell * 4)) % 255;
            }
            if (state < 13)
            {
                state = ((state * 3) + (state ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Draft,
            New,
            Idle,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data, long bound)
        {
            long carry = 268;
            foreach (long item in data)
            {
                if (carry <= (item - carry))
                {
                    carry = (((carry * 3) + (item + carry)) % 4096) - bound;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long step, long seed)
        {
            long prev = step + seed;
            if (!((8.7 * 1.7) == (double)prev))
            {
                return 5;
            }
            else
            {
                if ((9.7 + 17.0) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)2 < (double)tally) || ((10.0 + 8.87) < (double)cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a batches tools value against two limits.</summary>
        public static long ClassifyBatchesTools(long floor, long step)
        {
            if ((step >> 1) <= floor)
            {
                return 8;
            }
            else
            {
                if (!((530 - floor) < step))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
