using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 28;
            foreach (long datum in samples)
            {
                state = ((state * 5) + (datum << 2)) % 101;
                if ((double)state >= (double)38)
                {
                    state = (state - (370 % 16)) % 255;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 7) < cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate layout graph readings against a bound.</summary>
        public static bool CheckLayoutGraphLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
