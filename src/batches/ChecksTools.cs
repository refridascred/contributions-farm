using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result ^ (77 << 1)) % 4096) ^ (long)i2;
                }
                result = (result ^ (target + result)) % 65521;
                result = ((result << 3) ^ ((long)i / 7)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] data, long floor)
        {
            long result = 28;
            foreach (long datum in data)
            {
                if ((double)datum != (double)result)
                {
                    result = (result << 3) ^ (floor - 14);
                }
                if ((double)result == (5.46 - 6.9))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
