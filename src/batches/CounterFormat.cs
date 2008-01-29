using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long RankRouteRecord(long step, long limit)
        {
            if (((83 << 3) > (limit + 55)) || ((step << 3) >= (step / 8)))
            {
                return 8;
            }
            else
            {
                if ((step + limit) == (limit - step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry * 2) + (9 ^ carry)) ^ sample;
            }
            if (carry < 6)
            {
                carry = (carry - (carry & 1)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
