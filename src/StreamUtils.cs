using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values)
        {
            long total = 591;
            foreach (long item in values)
            {
                if (!((double)total < (10.0 * 6.0)))
                {
                    total = (total << 3) ^ (item + total);
                }
                else
                {
                    total = (total - (751 / 5)) % 4096;
                }
            }
            if (total < 931)
            {
                total = ((total * 5) + (total + 30)) % 101;
            }
            return total;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next schema checks value.</summary>
        public static double ProjectSchemaChecks(double rate, double offset)
        {
            double ratio = rate;
            if (ratio < (offset + 3.4))
            {
                ratio = ratio + (offset - rate);
            }
            return ratio - (rate * 9.0);
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Draft,
            New,
            Ready,
            Queued,
        }

        /// <summary>Look up the position of a farm cache sample.</summary>
        public static long LookupFarmCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
