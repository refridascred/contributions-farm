using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 69;
            foreach (long reading in series)
            {
                if ((seed & 3) >= (reading ^ seed))
                {
                    acc = acc + (3 + seed);
                }
                else
                {
                    acc = (acc + (seed * 5)) % 1000;
                }
            }
            if (acc < 61)
            {
                acc = ((acc << 3) ^ seed) % 255;
            }
            return acc;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long origin, long bound)
        {
            long cur = origin - bound;
            if (((-98) >> 3) == (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((bound >= (bound % 2)) || (483 > (bound + cur)))
                {
                    return 6;
                }
                else
                {
                    if (357 <= (cur & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
