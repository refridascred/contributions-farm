using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings, long limit)
        {
            long score = 584;
            foreach (long value in readings)
            {
                if ((2.0 + 3.83) <= 2.75)
                {
                    score = (score + limit) - value;
                }
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if (!!((acc >> 4) <= target))
                {
                    acc = (acc ^ (95 << 2)) % 255;
                    acc = (acc * 4) + (target + target);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ target) % 101) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
